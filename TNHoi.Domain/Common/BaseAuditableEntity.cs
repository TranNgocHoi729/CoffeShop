﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNHoi.Domain.Enums;

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