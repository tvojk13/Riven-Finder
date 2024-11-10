using Newtonsoft.Json;
using Riven_finder.Models;

namespace Riven_finder
{
    public partial class EditTaskForm : Form
    {
        private int _taskId;
        private Models.Task currentTask;

        public EditTaskForm(int taskId)
        {
            InitializeComponent();
            _taskId = taskId;
            taskPanel.rightButton.Text = "Save";
            taskPanel.rightButton.Click += saveChangesTaskButton_Click;
            taskPanel.cancelButton.Click += cancelTaskButton_Click;
            LoadInfo();
        }

        private void LoadInfo()
        {
            Models.Task currentTask = Models.Task.Get(_taskId);

            taskPanel.taskNameTextBox.Text = currentTask.TaskName;
            taskPanel.itemNameComboBox.SelectedItem = currentTask.ItemName;
            taskPanel.maxPriceNumeric.Value = currentTask.MaxPrice;
            taskPanel.userStatusComboBox.SelectedItem = currentTask.UserGameStatus;
            taskPanel.polarityComboBox.SelectedItem = currentTask.Polarity;
            taskPanel.maxMasteryNumeric.Value = currentTask.MaxMastery;
            taskPanel.maxRerollsNumeric.Value = currentTask.MaxRerolls;
            taskPanel.imageBytes = currentTask.ItemImage;
        }

        private void saveChangesTaskButton_Click(object sender, EventArgs e)
        {
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

            Models.Task existingTask = tasks.FirstOrDefault(t => t.Id == _taskId);

            existingTask.TaskName = taskPanel.taskNameTextBox.Text;
            existingTask.ItemName = taskPanel.itemNameComboBox.Text;
            existingTask.MaxPrice = (int)taskPanel.maxPriceNumeric.Value;
            existingTask.UserGameStatus = (UserStatus)taskPanel.userStatusComboBox.SelectedValue;
            existingTask.Polarity = (RivenPolarity)taskPanel.polarityComboBox.SelectedValue;
            existingTask.MaxMastery = (int)taskPanel.maxMasteryNumeric.Value;
            existingTask.MaxRerolls = (int)taskPanel.maxRerollsNumeric.Value;
            existingTask.ItemImage = taskPanel.imageBytes;

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
