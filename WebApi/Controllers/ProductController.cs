using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Entities;
using WebApi.Services;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
	private readonly ProductService _productService;

	public ProductsController(ProductService productService)
	{
		_productService = productService;
	}

	[HttpGet]
	public async Task<IActionResult> Get()
	{
		return Ok(await _productService.GetAllAsync());
	}

	[HttpGet]
	[Route("Category/{categoryName}")]
	public async Task<IActionResult> GetByTag(string categoryName)
	{
		return Ok(await _productService.GetByCategoryAsync(categoryName));
	}

	[HttpGet]
	[Route("Id/{id}")]
	public async Task<IActionResult> GetById(int id)
	{
		return Ok(await _productService.GetByIdAsync(id));
	}

	[HttpPost]
	[Route("Create")]
	public async Task<IActionResult> CreateProduct(ProductEntity model)
	{
		if (ModelState.IsValid)
		{
			if (await _productService.AddAsync(model) != null)
			{
				return Created("", null);
			}
		}

		return BadRequest(model);
	}
}
