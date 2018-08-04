using Serenity.Services;

namespace SereneTutorial.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}