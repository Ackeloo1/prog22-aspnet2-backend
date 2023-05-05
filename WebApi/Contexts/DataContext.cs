namespace WebApi.Contexts
{
    public class DataContext
    {

        public DbSet<ProductEntity> Products { get; set; }
		public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PaymentMethodEntity> PaymentMethods { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<ReviewsEntity> Reviews { get; set; }

    }
}
