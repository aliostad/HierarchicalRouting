using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HierarchicalRouting.Models
{
	public class Tyre
	{
		public int CarId { get; set; }

		public TyreSide Side { get; set; }

		public string Brand { get; set; }

		public string SizeCode { get; set; }

		public DateTime LastChangeDate { get; set; }

		public TyreStatus Status { get; set; }

		public string LastMechanicName { get; set; }
	}
}