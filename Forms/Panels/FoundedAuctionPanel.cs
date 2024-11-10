using Riven_finder.Models;
using System.Diagnostics;

namespace Riven_finder
{
    public partial class FoundedAuctionPanel : UserControl
    {
        Auction auction;
        string jwtToken;
        public FoundedAuctionPanel(Auction foundedAuction)
        {
            InitializeComponent();
            auction = foundedAuction;
            LoadJWT();
            System.Threading.Tasks.Task.Run(() => LoadOwnerAvatar(auction.owner.avatar));
            LoadInfo();
        }

        private void LoadInfo()
        {
            ownerNameLabel.Text = auction.owner.ingame_name;
            ownerStatusLabel.Text = auction.owner.status;
            updatedLabel.Text = auction.updated.ToString();
            itemNameLabel.Text = (auction.item.weapon_url_name + " " + auction.item.name).ToUpper();
            priceLabel.Text = auction.buyout_price.ToString();
            mrLabel.Text += auction.item.mastery_level;
            ranksLabel.Text += auction.item.mod_rank;
            rerollsLabel.Text += auction.item.re_rolls;
            polarityLabel.Text = auction.item.polarity;

            switch (ownerStatusLabel.Text)
            {
                case "ingame":
                    ownerStatusLabel.ForeColor = Color.BlueViolet;
                    break;
                case "online":
                    ownerStatusLabel.ForeColor = Color.Green;
                    break;
                case "offline":
                    ownerStatusLabel.ForeColor = Color.Red;
                    break;
            }

            // load attrs
            foreach (Models.Attribute attribute in auction.item.attributes)
            {
                Label attrLabel = new Label();
                attrLabel.Name = attribute.url_name + attribute.value.ToString();
                attrLabel.Text = attribute.url_name + ": " + attribute.value.ToString();
                attrLabel.AutoSize = true;

                if (attribute.value < 0)
                    attrLabel.ForeColor = Color.Red;
                else
                    attrLabel.ForeColor = Color.Green;

                flowLayoutPanel1.Controls.Add(attrLabel);
            }
        }

        private void LoadJWT()
        {
            jwtToken = System.IO.File.ReadAllText("loginFile.json");
        }

        private async void LoadOwnerAvatar(string avatarUrl)
        {
            string url = "https://warframe.market/static/assets/" + avatarUrl;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/98.0.4758.80 Safari/537.36");
                    client.DefaultRequestHeaders.Add("Authorization", jwtToken);
                    client.DefaultRequestHeaders.Add("platform", "pc");
                    client.DefaultRequestHeaders.Add("language", "en");

                    byte[] imageBytes = await client.GetByteArrayAsync(url);

                    using (MemoryStream stream = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(stream);
                        pictureBox1.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show($"Image error: {ex.Message}");
            }
        }

        private void itemNameLabel_Click(object sender, EventArgs e)
        {
            string urlAucTemplate = $"https://warframe.market/auction/";

            Process.Start(new ProcessStartInfo
            {
                FileName = urlAucTemplate + auction.id,
                UseShellExecute = true
            });
        }
    }
}
