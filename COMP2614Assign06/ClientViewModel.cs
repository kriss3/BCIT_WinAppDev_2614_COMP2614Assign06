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

		public void SetDisplayProduct(Client cl)
		{
			this.ClientCode = cl.ClientCode;
		}
	}
}
