using System.ComponentModel;
using System.Runtime.CompilerServices;

using BusinessLib.Common;

namespace COMP2614Assign06.UI
{
	/// <summary>
	/// @Author: Krzysztof Szczurowski
	/// @Repo: https://github.com/kriss3/BCIT_WinAppDev_2614_COMP2614Assign06.git
	/// @Date: June 2017
	/// </summary>
	public class ClientViewModel : INotifyPropertyChanged
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
		public ClientCollection Clients { get; set; }

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

		public void SetDisplayClient(Client cl)
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

		public Client GetDisplayClient()
		{
			return new Client { ClientCode = this.ClientCode,
								CompanyName = this.CompanyName,
								Address1 = this.Address1,
								City = this.City,
								Province = this.Province,
								PostalCode = this.PostalCode,
								YTDSale = this.YTDSale,
								CreditHold = this.CreditHold,
								Notes = this.Notes };
		}
	}
}
