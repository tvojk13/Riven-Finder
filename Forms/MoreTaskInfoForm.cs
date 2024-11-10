using System.Data;
using Newtonsoft.Json;
using Riven_finder.Models;
using Riven_finder.Models.Responses;
using Riven_finder.Models.Responses.RivenAuction;
using System.Net.Http.Headers;

namespace Riven_finder
{
    public partial class MoreTaskInfoForm : Form
    {
        private Models.Task task;
        private List<Auction> foundedAuctions;
        private string jwtToken;
        private const string UrlAucTemplate = "https://api.warframe.market/v1/auctions/";
        private readonly LoadingPanel loadingPanel;

        public MoreTaskInfoForm(int taskId)
        {
            InitializeComponent();

            // Initialize UI Events
            Load += CenterLoadingPanel;
            LocationChanged += CenterLoadingPanel;
            SizeChanged += CenterLoadingPanel;

            // Setup Loading Panel
            loadingPanel = new LoadingPanel();
            loadingPanel.Owner = this;
            loadingPanel.Show();
            loadingPanel.BringToFront();

            // Hide form controls initially
            HideControls();

            // Load task data and JWT token
            task = Models.Task.Get(taskId);
            jwtToken = LoadJWT();

            // Display task info
            DisplayTaskInfo();

            // Load and display auctions for the task
            LoadAndShowAuctions();
        }

        private void CenterLoadingPanel(object sender, EventArgs e)
        {
            if (loadingPanel == null || loadingPanel.IsDisposed)
                return;

            loadingPanel.Location = new Point(
                Location.X + (Width - loadingPanel.Width) / 2,
                Location.Y + (Height - loadingPanel.Height) / 2
            );
        }

        private static string LoadJWT() =>
            System.IO.File.ReadAllText("loginFile.json");

        private void DisplayTaskInfo()
        {
            taskIdLabelValue.Text = task.Id.ToString();
            taskStatusLabelValue.Text = task.Status.ToString();
        }

        private void HideControls()
        {
            foreach (Control component in Controls)
                component.Visible = false;
        }

        private void ShowControls()
        {
            foreach (Control component in Controls)
                component.Visible = true;
        }

        private async void LoadAndShowAuctions()
        {
            string url = $"{UrlAucTemplate}search?type=riven&buyout_policy=with&sort_by=price_asc&weapon_url_name={task.UrlName}";

            using var client = new HttpClient();
            SetupClientHeaders(client);

            try
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                var auctionResponse = JsonConvert.DeserializeObject<AuctionResponse>(jsonResponse);

                foundedAuctions = FilterAuctions(auctionResponse.payload.auctions);
                DisplayAuctions();
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show($"Request error: {e.Message}");
            }
            finally
            {
                loadingPanel.Dispose();
                ShowControls();
            }
        }

        private void SetupClientHeaders(HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/98.0.4758.80 Safari/537.36");
            client.DefaultRequestHeaders.Add("Authorization", jwtToken);
            client.DefaultRequestHeaders.Add("platform", "pc");
            client.DefaultRequestHeaders.Add("language", "en");
        }

        private List<Auction> FilterAuctions(IEnumerable<Auction> auctions) =>
            auctions
                .Where(a => a.buyout_price <= task.MaxPrice &&
                            (task.UserGameStatus == UserStatus.All ||
                             task.UserGameStatus.ToString().ToLower() == a.owner.status))
                .ToList();

        private void DisplayAuctions()
        {
            foreach (var auction in foundedAuctions)
            {
                var auctionPanel = new FoundedAuctionPanel(auction);
                flowLayoutPanel1.Controls.Add(auctionPanel);
            }
        }
    }
}
