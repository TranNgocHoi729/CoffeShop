using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TNHoi.Infrastructure.Persistence
{
	public class ApplicationDbContext : DbContext
	{
		private readonly IConfiguration _configuration;

		public ApplicationDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
		{
			_configuration = configuration;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ConnectionSQL"));
		}

	}
}
