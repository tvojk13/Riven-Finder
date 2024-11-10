namespace Riven_finder.Models.Responses.RivenItem
{
    public class RivenItemResponse
    {
        public Payload payload { get; set; }
    }
}

namespace Riven_finder.Models.Responses.RivenItem
{
    public class Payload
    {
        public Item[] items { get; set; }
    }
}

namespace Riven_finder.Models.Responses
{
    public class Item
    {
        public string icon { get; set; }
        public string riven_type { get; set; }
        public string item_name { get; set; }
        public string url_name { get; set; }
        public string mastery_level { get; set; }
        public string group { get; set; }
        public string icon_format { get; set; }
        public string id { get; set; }
        public string thumb { get; set; }
    }
}