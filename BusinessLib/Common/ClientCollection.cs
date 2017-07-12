using System;
using System.ComponentModel;
using System.Linq;

namespace BusinessLib.Common
{
	/// <summary>
	/// @Author: Krzysztof Szczurowski
	/// @Repo: https://github.com/kriss3/BCIT_WinAppDev_2614_COMP2614Assign06.git
	/// @Date: June 2017
	/// </summary>
	public class ClientCollection : BindingList<Client>
	{
		/// <summary>
		/// 
		/// </summary>
		public decimal TotalYTDSales
		{
			get
			{
				return this.Where(x => x.CreditHold == true).Select(x=>x.YTDSale).Sum();
			} 
		}

		/// <summary>
		/// 
		/// </summary>
		public decimal CreditHoldCount
		{
			get
			{
				return this.Select(x => Convert.ToInt32(x.CreditHold)).Sum();
			}
		}
	}
}
