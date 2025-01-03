using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDemo.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions dbContextOptions):base(dbContextOptions) 
		{ 
		}
	}
}
