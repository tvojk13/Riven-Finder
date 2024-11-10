using Newtonsoft.Json;
using Riven_finder.Models;
using Riven_finder.Models.Responses.RivenAuction;

namespace Riven_finder
{
    public partial class MainForm : Form
    {
        private List<Models.Task> tasks;
        private List<Models.Task> activeTasks = new List<Models.Task>();
        private bool isProcessing = false;
        private LoadingPanel loadingPanel;

        private string urlAucTemplate = $"https://api.warframe.market/v1/auctions/";
        private string urlItems = "https://api.warframe.market/v1/riven/items";

        private string jwtToken;

        public MainForm()
        {
            InitializeComponent();

            loadingPanel = new LoadingPanel();
            loadingPanel.Owner = this;
            loadingPanel.Show();
            loadingPanel.BringToFront();

            if (!System.IO.File.Exists("loginFile.json") || new FileInfo("loginFile.json").Length == 0)
            {
                this.Hide();
                LoginFrom loginForm = new LoginFrom();
                loginForm.ShowDialog();
                if (!System.IO.File.Exists("loginFile.json") || new FileInfo("loginFile.json").Length == 0)
                {
                    Environment.Exit(0);
                }
            }

            this.Load += CenterLoadingPanel;
            this.LocationChanged += CenterLoadingPanel;
            this.SizeChanged += CenterLoadingPanel;

            foreach (Control component in this.Controls)
            {
                component.Visible = false;
            }

            LoadJWT();
            
            InitializeAsync();
        }

        private void LoadJWT()
        {
            jwtToken = System.IO.File.ReadAllText("loginFile.json");
        }

        private async void InitializeAsync()
        {
            await InitRivenItems();
            UpdateDataGrid(false);
            await StartProcessingLoopAsync();
        }

        private void CenterLoadingPanel(object sender, EventArgs e)
        {
            if (loadingPanel != null && !loadingPanel.IsDisposed)
            {
                loadingPanel.Location = new Point(
                    this.Location.X + (this.Width - loadingPanel.Width) / 2,
                    this.Location.Y + (this.Height - loadingPanel.Height) / 2
                );
            }
        }

        private async System.Threading.Tasks.Task InitRivenItems()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlItems);

                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    System.IO.File.WriteAllText("RivenItems.json", jsonResponse);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                }
            }
        }

        private void createTask_Click(object sender, EventArgs e)
        {
            using (CreateTaskForm _ = new CreateTaskForm())
            {
                _.ShowDialog();
                UpdateDataGrid(false);
            }
        }

        private void UpdateDataGrid(bool textChanged)
        {
            string tasksFile = "tasks.json";

            if (!System.IO.File.Exists(tasksFile))
                System.IO.File.WriteAllText("tasks.json", "[]");

            string json = System.IO.File.ReadAllText(tasksFile);
            tasks = JsonConvert.DeserializeObject<List<Models.Task>>(json);
            if (textChanged)
                return;
            tasksBindingSource.DataSource = tasks;
            totalTasks.Text = tasks.Count.ToString();

            foreach (Control component in this.Controls)
            {
                component.Visible = true;
            }
            
            loadingPanel.Dispose();
        }

        private void tasksDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int taskId = (int)tasksDataGrid.Rows[e.RowIndex].Cells[0].Value;
            string taskName = (string)tasksDataGrid.Rows[e.RowIndex].Cells[1].Value;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int columnIndex = e.ColumnIndex;

                string columnName = tasksDataGrid.Columns[columnIndex].Name;

                switch (columnName)
                {
                    case "runColumn":
                        Models.Task.ChangeStatus(taskId, Models.TaskStatus.InProgress);
                        tasksDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        break;

                    case "pauseColumn":
                        tasksDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                        Models.Task.ChangeStatus(taskId, Models.TaskStatus.Paused);
                        break;

                    case "editColumn":
                        _ = new EditTaskForm(taskId).ShowDialog();
                        break;

                    case "deleteColumn":
                        DialogResult result = MessageBox.Show(
                            $"Do you want to delete {taskName}?", "Confirmation",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                            Models.Task.Delete(taskId);
                        break;
                }
                UpdateDataGrid(false);
            }
        }

        private void tasksDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tasksDataGrid.Columns[e.ColumnIndex].Name == "statusColumn" && e.RowIndex >= 0)
            {
                string status = e.Value?.ToString();

                if (status == "Founded")
                {
                    tasksDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (status == "InProgress")
                {
                    tasksDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else if (status == "Paused")
                {
                    tasksDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                }
                else if (status == "New")
                {
                    tasksDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        private async System.Threading.Tasks.Task StartProcessingLoopAsync()
        {
            while (true)
            {
                activeTasks.Clear();
                activeTasks.AddRange(tasks.Where(task => task.Status == Models.TaskStatus.InProgress));
                if (!isProcessing)
                {
                    await ProcessItemsAsync();
                }

                await System.Threading.Tasks.Task.Delay(3000);
            }
        }

        private async System.Threading.Tasks.Task ProcessItemsAsync()
        {
            if (isProcessing || activeTasks.Count == 0)
                return;

            isProcessing = true;

            foreach (Models.Task task in activeTasks)
            {
                string searchTemplate = $@"search?type=riven&buyout_policy=with&sort_by=price_asc&weapon_url_name={task.UrlName}";
                string url = urlAucTemplate + searchTemplate;

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/98.0.4758.80 Safari/537.36");
                    client.DefaultRequestHeaders.Add("Authorization", jwtToken);
                    client.DefaultRequestHeaders.Add("platform", "pc");
                    client.DefaultRequestHeaders.Add("language", "en");

                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(url);
                        response.EnsureSuccessStatusCode();

                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        AuctionResponse auctionResponse = JsonConvert.DeserializeObject<AuctionResponse>(jsonResponse);

                        List<Auction> foundedAuctions = auctionResponse.payload.auctions
                            .Where(a => a.buyout_price <= task.MaxPrice &&
                                        (task.UserGameStatus == UserStatus.All ||
                                         task.UserGameStatus.ToString().ToLower() == a.owner.status))
                            .ToList();

                        if (foundedAuctions.Any())
                        {
                            task.FoundedAuctions = foundedAuctions;
                            Models.Task.ChangeStatus(task.Id, Models.TaskStatus.Founded);
                        }
                    }
                    catch (HttpRequestException e)
                    {
                        MessageBox.Show($"Request error: {e.Message}");
                    }
                }
            }
            UpdateDataGrid(false);
            isProcessing = false;
        }


        private void tasksDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tasksDataGrid.Columns[e.ColumnIndex].Index <= 4 && e.RowIndex >= 0)
            {
                new MoreTaskInfoForm(e.RowIndex + 1).Show();
            }
        }
    }
}
