using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06
{
	class ClientViewModel : INotifyPropertyChanged
	{
		private string clientCode;
		private string companyName;
		private string address1;
		private string city;
		private string province;
		private string postalCode;
		private decimal ytdSale;
		private bool credtiHold;
		private string notes;

		public event PropertyChangedEventHandler PropertyChanged;

		public ClientViewModel(ClientCollection clients)
		{
			this.Clients = clients;
		}
		private void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		public ClientCollection Clients { get; }

		public string ClientCode
		{
			get { return clientCode; }
			set
			{
				clientCode = value;
				OnPropertyChanged();
			}
		}

		public string CompanyName
		{
			get { return companyName; }
			set
			{
				companyName = value;
				OnPropertyChanged();
			}
		}

		public string Address1
		{
			get { return address1; }
			set
			{
				address1 = value;
				OnPropertyChanged();
			}
		}

		public string City
		{
			get { return city; }
			set
			{
				city = value;
				OnPropertyChanged();
			}
		}

		public string Province
		{
			get { return province; }
			set
			{
				province = value;
				OnPropertyChanged();
			}
		}

		public string PostalCode
		{
			get { return postalCode; }
			set
			{
				postalCode = value;
				OnPropertyChanged();
			}
		}

		public decimal YTDSale
		{
			get { return ytdSale; }
			set
			{
				ytdSale = value;
				OnPropertyChanged();
			}
		}

		public bool CreditHold
		{
			get { return credtiHold; }
			set
			{
				credtiHold = value;
				OnPropertyChanged();
			}
		}

		public string Notes
		{
			get { return notes; }
			set
			{
				notes = value;
				OnPropertyChanged();
			}
		}

		public void SetDisplayProduct(Client cl)
		{
			this.ClientCode = cl.ClientCode;
			this.CompanyName = cl.CompanyName;
			this.Address1 = cl.Address1;
			this.City = cl.City;
			this.Province = cl.Province;
			this.PostalCode = cl.PostalCode;
			this.YTDSale = cl.YTDSale;
			this.CreditHold = cl.CreditHold;
			this.Notes = cl.Notes;
		}
	}
}
