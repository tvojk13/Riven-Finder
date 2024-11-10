using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Riven_finder
{
    public partial class LoginFrom : Form
    {
        string jwtToken;

        public LoginFrom() => InitializeComponent();

        public static async Task<string> LoginAsync(string userLogin, string userPassword, string platform = "pc", string language = "en")
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("Authorization", "JWT");
                client.DefaultRequestHeaders.Add("platform", platform);
                client.DefaultRequestHeaders.Add("language", language);

                var content = new { email = userLogin, password = userPassword, auth_type = "header" };
                StringContent httpContent = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync("https://api.warframe.market/v1/auth/signin", httpContent);
                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                        return null;

                    var responseObject = JObject.Parse(await response.Content.ReadAsStringAsync());
                    return response.Headers.Contains("Authorization") ? response.Headers.GetValues("Authorization").FirstOrDefault() : null;
                }
                catch
                {
                    return null;
                }
            }
        }

        private async System.Threading.Tasks.Task Login()
        {
            jwtToken = await LoginAsync(userLoginTextBox.Text, userPasswordTextBox.Text);
            File.WriteAllText("loginFile.json", jwtToken);

            if (new FileInfo("loginFile.json").Length == 0)
                MessageBox.Show("Failed login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
