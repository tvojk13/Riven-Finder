namespace Riven_finder.Models
{
    public class Auction
    {
        public decimal? buyout_price { get; set; }
        public string note { get; set; }
        public int minimal_reputation { get; set; }
        public decimal StartingPrice { get; set; }
        public bool visible { get; set; }
        public Item item { get; set; }
        public Owner owner { get; set; }
        public string platform { get; set; }
        public bool closed { get; set; }
        public decimal? top_bid { get; set; }
        public string winner { get; set; }
        public string is_marked_for { get; set; }
        public DateTime? marked_operation_at { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public string note_raw { get; set; }
        public bool is_direct_sell { get; set; }
        public string id { get; set; }
        public bool @private { get; set; }
    }
}
