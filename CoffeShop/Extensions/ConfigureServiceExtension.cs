﻿using TNHoi.Infrastructure.Persistence.Configurations.DataType;

namespace CoffeShop.Extensions
{
	public static class ConfigureServiceExtension
	{
		public static void EntityFrameworkConfiguration(this WebApplicationBuilder builder)
		{
			builder.Services.AddSingleton(new DataTypeConfiguration
			{
				
			});
		}
	}
}