using System;
using System.ComponentModel;
using System.Linq;

namespace BusinessLib.Common
{
	public class ClientCollection : BindingList<Client>
	{
		public decimal TotalYTDSales
		{
			get
			{
				return this.Where(x => x.CreditHold == true).Select(x=>x.YTDSale).Sum();
			} 
		}

		public decimal CreditHoldCount
		{
			get
			{
				return this.Select(x => Convert.ToInt32(x.CreditHold)).Sum();
			}
		}
	}
}
