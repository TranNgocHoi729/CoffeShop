using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TNHoi.Domain.Entities;
using TNHoi.Infrastructure.Persistence.Configurations.DataType;

namespace TNHoi.Infrastructure.Persistence.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public UserConfiguration()
		{
		}
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.Property(p => p.Id).HasColumnType(DataTypeConfiguration.LongString);
			builder.Property(p => p.UserName).HasColumnType(DataTypeConfiguration.LongString).IsRequired();
			builder.Property(p => p.Password).HasColumnType(DataTypeConfiguration.ShortString).IsRequired();
			builder.Property(p => p.Email).HasColumnType(DataTypeConfiguration.ShortString).IsRequired();
			builder.Property(p => p.FullName).HasColumnType(DataTypeConfiguration.LongString).IsRequired();
			builder.Property(p => p.Phone).HasColumnType(DataTypeConfiguration.ShortString);
			builder.Property(p => p.Address).HasColumnType(DataTypeConfiguration.LongString);
			builder.Property(p => p.Gender).HasColumnType(DataTypeConfiguration.IntType);
			builder.Property(p => p.DateOfBirth).HasColumnType(DataTypeConfiguration.TimeType);
			builder.Property(p => p.CreatedBy).HasColumnType(DataTypeConfiguration.LongString);
			builder.Property(p => p.Created).HasColumnType(DataTypeConfiguration.TimeType);
			builder.Property(p => p.LastModifiedBy).HasColumnType(DataTypeConfiguration.LongString);
			builder.Property(p => p.LastModified).HasColumnType(DataTypeConfiguration.TimeType);
			builder.Property(p => p.Status).HasColumnType(DataTypeConfiguration.IntType).IsRequired();
			builder.Property(p => p.Description).HasColumnType(DataTypeConfiguration.LongString);
			builder.HasKey(key => key.Id);
		}
	}
}
