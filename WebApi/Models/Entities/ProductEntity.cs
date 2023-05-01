using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities;

public class ProductEntity
{
	[Key]
	public int ArticleNumber { get; set; }
	public string ProductName { get; set; } = null!;
	public string Description { get; set; } = null!;

	[Column(TypeName = "money")]
	public decimal Price { get; set; }
	public int StarRating { get; set; }
	public string? ImageURL { get; set; }

	public CategoryEntity Category { get; set; }
}
