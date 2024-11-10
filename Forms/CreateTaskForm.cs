using Newtonsoft.Json;
using Riven_finder.Models;
using Riven_finder.Models.Responses.RivenItem;

namespace Riven_finder
{
    public partial class CreateTaskForm : Form
    {
        public CreateTaskForm()
        {
            InitializeComponent();
            taskPanel.rightButton.Text = "Create";
            taskPanel.rightButton.Click += createTaskButton_Click;
            taskPanel.cancelButton.Click += cancelTaskButton_Click;
        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {
            string rivenItemsFile = "RivenItems.json";

            if (!File.Exists(rivenItemsFile))
            {
                File.Create("RivenItems.json");
            }

            string jsonResponse = File.ReadAllText(rivenItemsFile);
            RivenItemResponse rivenItems = JsonConvert.DeserializeObject<RivenItemResponse>(jsonResponse);

            List<Models.Responses.Item> itemsList = new List<Models.Responses.Item>(rivenItems.payload.items);

            string tasksFile = "tasks.json";

            List<Models.Task> tasks;
            if (File.Exists(tasksFile))
            {
                string json = File.ReadAllText(tasksFile);
                tasks = JsonConvert.DeserializeObject<List<Models.Task>>(json) ?? new List<Models.Task>();
            }
            else
            {
                tasks = new List<Models.Task>();
            }

            int newId = tasks.Count > 0 ? tasks.Max(t => t.Id) + 1 : 1;
            string urlName = itemsList.FirstOrDefault(t => t.item_name == taskPanel.itemNameComboBox.Text).url_name;

            Models.Task newTask = new Models.Task(newId,
                taskPanel.taskNameTextBox.Text,
                taskPanel.itemNameComboBox.Text,
                urlName,
                (int)taskPanel.maxPriceNumeric.Value,
                (UserStatus)taskPanel.userStatusComboBox.SelectedValue,
                (RivenPolarity)taskPanel.polarityComboBox.SelectedValue,
                (int)taskPanel.maxMasteryNumeric.Value,
                (int)taskPanel.maxRerollsNumeric.Value,
                taskPanel.imageBytes);

            tasks.Add(newTask);

            string updatedJson = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText(tasksFile, updatedJson);

            this.Close();
        }

        private void cancelTaskButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
