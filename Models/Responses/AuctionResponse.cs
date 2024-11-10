namespace Riven_finder.Models.Responses.RivenAuction
{
    public class AuctionResponse
    {
        public Payload payload { get; set; }
    }
}

namespace Riven_finder.Models.Responses.RivenAuction
{
    public class Payload
    {
        public List<Auction> auctions { get; set; }
    }
}