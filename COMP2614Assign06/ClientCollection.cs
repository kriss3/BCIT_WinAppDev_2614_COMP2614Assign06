using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06
{
	public class ClientCollection : BindingList<Client>
	{
		public decimal TotalYTDSales
		{
			get
			{
				return this.Select(x => x.YTDSale).Sum();
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
