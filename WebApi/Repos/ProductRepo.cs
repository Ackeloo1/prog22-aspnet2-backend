using Microsoft.EntityFrameworkCore;
using WebApi.Contexts;
using WebApi.Models.Entities;

namespace WebApi.Repos;

public class ProductRepo : BaseRepo<ProductEntity, DataContext>
{
	public ProductRepo(DataContext context) : base(context)
	{
	}

	// Skriver över bas-repons "GetAll" metod för att få med kategorierna också
	public override async Task<IEnumerable<ProductEntity>> GetAllAsync()
	{
		return await _context.Products.Include(x => x.Category).ToListAsync();
	}



	// Lägger till nya metoder
	public async Task<IEnumerable<ProductEntity>> GetByCategoryAsync(string categoryName)
	{
		return await _context.Products
			.Where(x => x.Category.CategoryName == categoryName)
			.Include(x => x.Category)
			.ToListAsync();
	}

	public async Task<ProductEntity> GetByIdAsync(int id)
	{
		return await base.GetAsync(x => x.ArticleNumber == id);
	}
}
