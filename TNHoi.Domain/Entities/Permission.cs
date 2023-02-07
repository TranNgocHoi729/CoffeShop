namespace TNHoi.Domain.Entities
{
	public class Permission : BaseEntity
	{
		public string Name { get; set; }

		public string Code { get; set; }

		public int Order { get; set; }

	}
}
