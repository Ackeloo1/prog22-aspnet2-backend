namespace WebApi.Entities
{
    public class UserProfileEntity
    {
        public string UserId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
