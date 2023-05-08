using WebApi.Models.Entities;
using WebApi.Repos;

namespace WebApi.Services;

public class AddressService
{
	private readonly AddressRepo _addressRepo;

	public AddressService(AddressRepo addressRepo)
	{
		_addressRepo = addressRepo;
	}


	public async Task<IEnumerable<AddressEntity>> GetAllAsync()
	{
		return await _addressRepo.GetAllAsync();
	}

	public async Task<IList<AddressEntity>> SearchAsync(string categoryName)
	{
		return await _addressRepo.SearchAsync(categoryName);
	}

	public async Task<AddressEntity> GetByIdAsync(int id)
	{
		return await _addressRepo.GetByIdAsync(id);
	}

	public async Task<AddressEntity> AddAsync(AddressEntity entity)
	{
		return await _addressRepo.AddAsync(entity);
	}

}
