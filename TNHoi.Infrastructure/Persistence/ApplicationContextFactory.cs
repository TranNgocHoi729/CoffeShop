using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNHoi.Infrastructure.Persistence
{
	public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
	{
		public ApplicationDbContext CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
			var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext> ();
			optionBuilder.UseSqlServer(configuration.GetConnectionString("ConnectionSQL"));
			return new ApplicationDbContext(optionBuilder.Options);
		}
	}
}
