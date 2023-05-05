using Microsoft.EntityFrameworkCore;
using WebApi.Contexts;
using WebApi.Models.Entities;

namespace WebApi.Repos;

public class AddressRepo : BaseRepo<AddressEntity, DataContext>
{
	public AddressRepo(DataContext context) : base(context)
	{
	}


	public async Task<AddressEntity> GetByIdAsync(int id)
	{
		return await base.GetAsync(x => x.AddressId == id);
	}

	public async Task<IList<AddressEntity>> SearchAsync(string searchString)
	{
		return await _context.Addresses
			.Where(x =>
			x.Street.Contains(searchString) ||
			x.City.Contains(searchString) ||
			x.Country.Contains(searchString) ||
			x.PostalCode.Contains(searchString))
		.ToListAsync();
	}
}
