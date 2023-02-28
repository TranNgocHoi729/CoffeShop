using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TNHoi.Infrastructure.Persistence
{
	public class ApplicationDbContext : DbContext
	{

		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder
		}

	}
}
