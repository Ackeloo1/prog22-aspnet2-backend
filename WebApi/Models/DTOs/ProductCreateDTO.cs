using WebApi.Models.Entities;

namespace WebApi.Models.DTOs
{
	public class ProductCreateDTO
	{
		public string ProductName { get; set; } = null!;
		public string Description { get; set; } = null!;
		public decimal Price { get; set; }
		public int StarRating { get; set; }
		public string? ImageURL { get; set; }
		public int CategoryId { get; set; }

		public static implicit operator ProductEntity(ProductCreateDTO req)
		{
			return new ProductEntity
			{
				ProductName = req.ProductName,
				Description = req.Description,
				Price = req.Price,
				StarRating = req.StarRating,
				ImageURL = req.ImageURL
			};
		}
	}
}
