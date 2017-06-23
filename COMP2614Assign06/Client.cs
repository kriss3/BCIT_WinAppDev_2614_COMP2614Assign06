using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06
{
	public class Client
	{
		public string ClientCode { get; set; }
		public string CompanyName { get; set; }
		public string Address1 { get; set; }
		public string City { get; set; }
		public string Province { get; set; }
		public string PostalCode { get; set; }
		public decimal YTDSale { get; set; }
		public bool CreditHold { get; set; }
		public string Notes { get; set; }

		public Client(string clientCode, string companyName, string address1, string city,
					  string province, string postalCode, decimal ytdSale, bool creditHold, 
					  string notes)
		{
			this.ClientCode = clientCode;
			this.CompanyName = companyName;
			this.Address1 = address1;
			this.City = city;
			this.Province = province;
			this.PostalCode = postalCode;
			this.YTDSale = ytdSale;
			this.CreditHold = creditHold;
			this.Notes = notes;
		}

	}
}
