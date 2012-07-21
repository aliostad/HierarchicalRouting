using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HierarchicalRouting.Models
{
	public class Car
	{
		public int Id { get; set; }

		private Dictionary<TyreSide, Tyre> _tyres = new Dictionary<TyreSide, Tyre>();

		public string Make { get; set; }

		public string Model { get; set; }

		public int Year { get; set; }

		public string RegistrationNumber { get; set; }

		public Dictionary<TyreSide, Tyre> Tyres
		{
			get { return _tyres; }
		}
	}
}