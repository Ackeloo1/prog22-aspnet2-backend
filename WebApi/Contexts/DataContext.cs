using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities;

namespace WebApi.Contexts
{
    public class DataContext : DbContext
    {
		public DbSet<ProductEntity> Products { get; set; }
		public DbSet<CategoryEntity> Categories { get; set; }


	}
}
