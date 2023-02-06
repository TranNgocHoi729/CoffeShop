namespace TNHoi.Domain.Common
{
	public class BaseAuditableEntity : BaseEntity
	{
		public DateTime Created { get; set; }

		public string? CreatedBy { get; set; }

		public DateTime? LastModified { get; set; }

		public string? LastModifiedBy { get; set; }

		public Status Status { get; set; }

		public string Description { get; set; } = "";
	}
}
