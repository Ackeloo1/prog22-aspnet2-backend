using WebApi.Models.Entities;

namespace WebApi.DTOs
{
    public class ProductHttpRequest
    {

        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Tag { get; set; } = null!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }




    }
}
