﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNHoi.Domain.Common;
using TNHoi.Domain.Enums;

namespace TNHoi.Domain.Entities
{
	public class User : BaseEntity
	{
		public string UserName { get; set; }

		public string Password { get; set; }

		public string Email { get; set; }

		public string FullName { get; set; }

		public string Phone { get; set; } = "";

		public string Address { get; set; } = "";

		public Gender Gender { get; set; } = Gender.MALE;

		public DateTime? DateOfBirth { get; set; }


	}
}
