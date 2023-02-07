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
		private readonly DataTypeConfiguration _dataType;

		public RoleConfiguration(DataTypeConfiguration dataType)
		{
			_dataType = dataType;
		}

		public void Configure(EntityTypeBuilder<Role> builder)
		{
			builder.Property(p => p.Id).HasColumnType(_dataType.LongString);
			builder.Property(p => p.Name).HasColumnType(_dataType.LongString);
			builder.Property(p => p.CreatedBy).HasColumnType(_dataType.LongString);
			builder.Property(p => p.Created).HasColumnType(_dataType.TimeType);
			builder.Property(p => p.LastModifiedBy).HasColumnType(_dataType.LongString);
			builder.Property(p => p.LastModified).HasColumnType(_dataType.TimeType);
			builder.Property(p => p.Status).HasColumnType(_dataType.IntType);
			builder.Property(p => p.Description).HasColumnType(_dataType.LongString);
			builder.HasKey(key => key.Id);
		}
	}
}
