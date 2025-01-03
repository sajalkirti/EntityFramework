using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDemo.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions dbContextOptions):base(dbContextOptions) 
		{ 
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Currency>().HasData(
					new Currency() { Id =1, CurrencyName="INR",CurrencyCode="INR"}
				);
		}
		public DbSet<Book> Books { get; set; }
		public DbSet<Language> Languages { get; set; }
		public DbSet<BookPrice> BooksPrices { get; set; }
		public DbSet<Currency> Currencies { get; set; }
	}
}
