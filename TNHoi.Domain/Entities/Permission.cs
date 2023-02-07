using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNHoi.Domain.Entities
{
	public class Permission : BaseEntity
	{
		public string Name { get; set; }

		public string Code { get; set; }

		public int Order { get; set; }

	}
}
