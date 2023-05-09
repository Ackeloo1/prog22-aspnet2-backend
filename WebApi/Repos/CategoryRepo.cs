using WebApi.Contexts;
using WebApi.Models.Entities;

namespace WebApi.Repos;

public class CategoryRepo : BaseRepo<CategoryEntity, DataContext>
{
	public CategoryRepo(DataContext context) : base(context)
	{
	}

	public async Task<CategoryEntity> GetByNameAsync(string categoryName)
	{
		return await base.GetAsync(x => x.CategoryName == categoryName);
	}

	public async Task<CategoryEntity> GetByIdAsync(int categoryId)
	{
		return await base.GetAsync(x => x.CategoryId == categoryId);
	}
}
