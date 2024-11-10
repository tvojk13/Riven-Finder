using Newtonsoft.Json;
using Riven_finder.Models;
using Riven_finder.Models.Responses.RivenItem;
using System.Data;

namespace Riven_finder
{
    public partial class TaskPanel : UserControl
    {
        private List<Models.Responses.Item> itemsList;
        public byte[] imageBytes;

        public TaskPanel()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            string rivenItemsFile = "RivenItems.json";

            if (!File.Exists(rivenItemsFile))
            {
                File.Create("RivenItems.json");
            }

            string jsonResponse = File.ReadAllText(rivenItemsFile);
            RivenItemResponse rivenItems = JsonConvert.DeserializeObject<RivenItemResponse>(jsonResponse);

            itemsList = new List<Models.Responses.Item>(rivenItems.payload.items);
            itemsList = itemsList.OrderBy(item => item.item_name).ToList();

            List<string> itemNames = itemsList.Select(item => item.item_name).ToList();
            itemNameComboBox.DataSource = itemNames;

            userStatusComboBox.DataSource = Enum.GetValues(typeof(UserStatus));
            polarityComboBox.DataSource = Enum.GetValues(typeof(RivenPolarity));
        }

        private async System.Threading.Tasks.Task LoadImageAsync()
        {
            Models.Responses.Item selectedItem = itemsList.FirstOrDefault(item => item.item_name == itemNameComboBox.SelectedItem);

            string urlName = selectedItem.icon;
            string picUrl = "https://warframe.market/static/assets/" + urlName;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    imageBytes = await client.GetByteArrayAsync(picUrl);

                    using (MemoryStream stream = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(stream);
                        itemPicture.Image = image; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Image error: {ex.Message}");
            }
        }

        private async void nameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            await LoadImageAsync();
        }
    }
}
