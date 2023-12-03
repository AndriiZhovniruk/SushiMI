using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Sushimi.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public DbSet<Dish> Dish { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
	}

    public class Dish
    {
		public int Id { get; set; }
		public string Category { get; set; }
		public string Name { get; set; }
		public int Weight { get; set; }
		public int Price { get; set; }
    }
}