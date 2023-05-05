using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Entities;
using WebApi.Services;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressController : ControllerBase
{
	private readonly AddressService _addressService;

	public AddressController(AddressService addressService)
	{
		_addressService = addressService;
	}

	[HttpGet]
	public async Task<IActionResult> Get()
	{
		return Ok(await _addressService.GetAllAsync());
	}

	[HttpGet]
	[Route("Search/{searchString}")]
	public async Task<IActionResult> Search(string searchString)
	{
		return Ok(await _addressService.SearchAsync(searchString));
	}

	[HttpGet]
	[Route("Id/{id}")]
	public async Task<IActionResult> GetById(int id)
	{
		return Ok(await _addressService.GetByIdAsync(id));
	}

	[HttpPost]
	[Route("Create")]
	public async Task<IActionResult> CreateAddress(AddressEntity model)
	{
		if (ModelState.IsValid)
		{
			if (await _addressService.AddAsync(model) != null)
			{
				return Created("", null);
			}
		}

		return BadRequest(model);
	}
}
