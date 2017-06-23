using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign06
{
	public partial class ClientEditDialog : Form
	{
		public ClientViewModel ClientVM { get; set; }

		public ClientEditDialog()
		{
			InitializeComponent();
		}

		private void ClientEditDialog_Load(object sender, EventArgs e)
		{
			setupBindings();
		}

		private void setupBindings()
		{
			textBoxClientCode.DataBindings.Add("Text", ClientVM, "ClientCode", false, DataSourceUpdateMode.OnValidation, "");
			textBoxCompanyName.DataBindings.Add("Text", ClientVM, "CompanyName", false, DataSourceUpdateMode.OnValidation, "");
			textBoxAddress1.DataBindings.Add("Text", ClientVM, "Address1", false, DataSourceUpdateMode.OnValidation, "");
			textBoxCity.DataBindings.Add("Text", ClientVM, "City", false, DataSourceUpdateMode.OnValidation, "");
			textBoxProvince.DataBindings.Add("Text", ClientVM, "Province", false, DataSourceUpdateMode.OnValidation, "");
			textBoxPostalCode.DataBindings.Add("Text", ClientVM, "PostalCode", false, DataSourceUpdateMode.OnValidation, "");
			textBoxYearToDateSale.DataBindings.Add("Text", ClientVM, "YTDSale", false, DataSourceUpdateMode.OnValidation, "");
			checkBoxCreditHold.DataBindings.Add("Checked", ClientVM, "CreditHold", false, DataSourceUpdateMode.OnValidation, "");
			textBoxNotes.DataBindings.Add("Text", ClientVM, "Notes", false, DataSourceUpdateMode.OnValidation, "");

		}
	}
}
