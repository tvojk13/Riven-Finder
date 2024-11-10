namespace Riven_finder.Models
{
    public class Item
    {
        public string name { get; set; }
        public int mastery_level { get; set; }
        public int mod_rank { get; set; }
        public string type { get; set; }
        public string weapon_url_name { get; set; }
        public string polarity { get; set; }
        public List<Attribute> attributes { get; set; }
        public int re_rolls { get; set; }
    }
}
