using WebApi.Models.DTOs;
using WebApi.Models.Entities;
using WebApi.Repos;

namespace WebApi.Services
{
	public class ProductService
	{

		// Lägger till CategoryRepo då det med stor sannolikhet kommer behöva användas i framtiden när vi utvecklat lite
		private readonly ProductRepo _productRepo;
		private readonly CategoryRepo _categoryRepo;

		public ProductService(ProductRepo productRepo, CategoryRepo categoryRepo)
		{
			_productRepo = productRepo;
			_categoryRepo = categoryRepo;
		}

		public async Task<IEnumerable<ProductEntity>> GetAllAsync()
		{
			return await _productRepo.GetAllAsync();
		}

		public async Task<IEnumerable<ProductEntity>> GetByCategoryAsync(string categoryName)
		{
			return await _productRepo.GetByCategoryAsync(categoryName);
		}

		public async Task<ProductEntity> GetByIdAsync(int id)
		{
			return await _productRepo.GetByIdAsync(id);
		}

		public async Task<ProductEntity> AddAsync(ProductCreateDTO dto)
		{
			ProductEntity entity = dto;
			entity.Category = await _categoryRepo.GetByIdAsync(dto.CategoryId);
			return await _productRepo.AddAsync(dto);
		}
	}
}
