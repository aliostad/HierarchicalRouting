using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HierarchicalRouting.Models;

namespace HierarchicalRouting.Business
{
	public class TyreManager
	{
		public void Repair(Tyre tyre)
		{
			tyre.Status = TyreStatus.OK;
		}

		public void Replace(Tyre tyre)
		{
			tyre.LastChangeDate = DateTime.Now;
			tyre.Status = TyreStatus.OK;
		}

		public void Puncture(Tyre tyre)
		{
			tyre.Status = TyreStatus.Punctured;
		}

		public void LowAir(Tyre tyre)
		{
			tyre.Status = TyreStatus.LowAir;
		}
	}
}