using Duende.IdentityServer.Configuration;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNHoi.Domain.Entities;
using TNHoi.Infrastructure.Persistence.Configurations.DataType;

namespace TNHoi.Infrastructure.Persistence.Configurations
{
	public class RoleConfiguration : IEntityTypeConfiguration<Role>
	{

		public RoleConfiguration()
		{
		}

		public void Configure(EntityTypeBuilder<Role> builder)
		{
			builder.Property(p => p.Id).HasColumnType(DataTypeConfiguration.LongString);
			builder.Property(p => p.Name).HasColumnType(DataTypeConfiguration.LongString);
			builder.Property(p => p.CreatedBy).HasColumnType(DataTypeConfiguration.LongString);
			builder.Property(p => p.Created).HasColumnType(DataTypeConfiguration.TimeType);
			builder.Property(p => p.LastModifiedBy).HasColumnType(DataTypeConfiguration.LongString);
			builder.Property(p => p.LastModified).HasColumnType(DataTypeConfiguration.TimeType);
			builder.Property(p => p.Status).HasColumnType(DataTypeConfiguration.IntType);
			builder.Property(p => p.Description).HasColumnType(DataTypeConfiguration.LongString);
			builder.HasKey(key => key.Id);
		}
	}
}
