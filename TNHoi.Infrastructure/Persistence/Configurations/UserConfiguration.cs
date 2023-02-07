using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TNHoi.Domain.Entities;
using TNHoi.Infrastructure.Persistence.Configurations.DataType;

namespace TNHoi.Infrastructure.Persistence.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		private readonly DataTypeConfiguration _dataType;

		public UserConfiguration(DataTypeConfiguration dataType)
		{
			_dataType = dataType;
		}
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.Property(p => p.Id).HasColumnType(_dataType.LongString);
			builder.Property(p => p.UserName).HasColumnType(_dataType.LongString);
			builder.Property(p => p.Password).HasColumnType(_dataType.ShortString);
			builder.Property(p => p.Email).HasColumnType(_dataType.ShortString);
			builder.Property(p => p.FullName).HasColumnType(_dataType.LongString);
			builder.Property(p => p.Phone).HasColumnType(_dataType.ShortString);
			builder.Property(p => p.Address).HasColumnType(_dataType.LongString);
			builder.Property(p => p.Gender).HasColumnType(_dataType.IntType);
			builder.Property(p => p.DateOfBirth).HasColumnType(_dataType.TimeType);
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
