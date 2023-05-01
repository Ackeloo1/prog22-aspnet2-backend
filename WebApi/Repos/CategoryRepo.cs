using WebApi.Contexts;
using WebApi.Models.Entities;

namespace WebApi.Repos;

public class CategoryRepo : BaseRepo<CategoryEntity, DataContext>
{
	public CategoryRepo(DataContext context) : base(context)
	{
	}

	public async Task<CategoryEntity> GetCategoryAsync(string categoryName)
	{
		return await base.GetAsync(x => x.CategoryName == categoryName);
	}
}
