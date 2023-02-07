using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNHoi.Infrastructure.ValueObjects
{
	internal class SQLServerDataType
	{
		internal const string ShortString = "varchar(50)";

		internal const string MediumString = "varchar(100)";

		internal const string LongString = "varchar(252)";

		internal const string IntType = "int";

		internal const string TimeType = "datetime2";
	}
}
