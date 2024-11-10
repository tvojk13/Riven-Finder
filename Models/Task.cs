using Newtonsoft.Json;

namespace Riven_finder.Models
{
    public enum TaskStatus
    {
        New,
        InProgress,
        Founded,
        Paused,
    }

    public enum UserStatus
    {
        All,
        InGame,
        Online,
        Offline,
    }

    public enum RivenPolarity
    {
        Any,
        Madurai,
        Naramon,
        Vazarin,
        Zenuri,
    }

    public class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string ItemName { get; set; }
        public string UrlName { get; set; }
        public int MaxPrice { get; set; }
        public TaskStatus Status { get; set; }
        public UserStatus UserGameStatus { get; set; }
        public RivenPolarity Polarity { get; set; }
        public int MaxMastery { get; set; }
        public int MaxRerolls { get; set; }
        public byte[] ItemImage { get; set; }
        public bool PriceGiven { get; }
        public List<Auction> FoundedAuctions { get; set; }


        public Task(int id, string taskName, string itemName, string urlName, int maxPrice, UserStatus userGameStatus, RivenPolarity rivenPolarity, int maxMastery, int maxRerolls, byte[] imageBytes)
        {
            Id = id;
            TaskName = taskName;
            ItemName = itemName;
            UrlName = urlName;
            if (maxPrice != -1)
                MaxPrice = maxPrice;
            else
                PriceGiven = false;
            UserGameStatus = userGameStatus;
            Polarity = rivenPolarity;
            if (maxMastery != -1)
                MaxMastery = maxMastery;
            if (maxRerolls != -1)
                MaxRerolls = maxRerolls;
            Status = TaskStatus.New;
            ItemImage = imageBytes;
            FoundedAuctions = new List<Auction>();
        }

        public static void ChangeStatus(int id, TaskStatus taskStatus)
        {
            string tasksFile = "tasks.json";
            List<Task> tasks = File.Exists(tasksFile)
                ? JsonConvert.DeserializeObject<List<Task>>(File.ReadAllText(tasksFile)) ?? new List<Task>()
                : new List<Task>();

            Task currentTask = tasks.FirstOrDefault(t => t.Id == id);

            if (currentTask != null)
            {
                currentTask.Status = taskStatus;

                File.WriteAllText(tasksFile, JsonConvert.SerializeObject(tasks, Formatting.Indented));
            }
        }


        public static void Delete(int id)
        {
            string TasksFile = "tasks.json";
            string json = File.ReadAllText(TasksFile);
            List<Task> tasks = JsonConvert.DeserializeObject<List<Task>>(json);

            Task taskToRemove = tasks.Find(task => task.Id == id);
            tasks.Remove(taskToRemove);

            string updatedJson = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText(TasksFile, updatedJson);
        }

        public static Task Get(int id)
        {
            string tasksFile = "tasks.json";

            if (File.Exists(tasksFile))
            {
                string json = File.ReadAllText(tasksFile);
                List<Task> tasks = JsonConvert.DeserializeObject<List<Task>>(json);

                Task task = tasks.Find(t => t.Id == id);

                return task;
            }
            return null;
        }
    }
}
