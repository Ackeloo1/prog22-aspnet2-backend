using WebApi.Models.Entities;

namespace WebApi.Models.DTOs
{
	public class AddressCreateDTO
	{
		public string Street { get; set; } = null!;
		public string City { get; set; } = null!;
		public string PostalCode { get; set; } = null!;
		public string Country { get; set; } = null!;

		public static implicit operator AddressEntity(AddressCreateDTO req)
		{
			return new AddressEntity
			{
				Street = req.Street,
				City = req.City,
				PostalCode = req.PostalCode,
				Country = req.Country
			};
		}
	}
}
