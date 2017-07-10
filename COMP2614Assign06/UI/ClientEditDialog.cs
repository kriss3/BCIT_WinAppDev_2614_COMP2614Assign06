using System;
using System.Windows.Forms;

using BusinessLib.Business;
using BusinessLib.Common;

namespace COMP2614Assign06.UI
{
	public partial class ClientEditDialog : Form
	{
		public ClientViewModel ClientVM { get; set; }
		public String callingButton { get; set; }

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
			comboBoxProvinces.DataSource = Helper.GetProvinces();

			textBoxClientCode.DataBindings.Add("Text", ClientVM, "ClientCode", false, DataSourceUpdateMode.OnValidation, "");
			textBoxCompanyName.DataBindings.Add("Text", ClientVM, "CompanyName", false, DataSourceUpdateMode.OnValidation, "");
			textBoxAddress1.DataBindings.Add("Text", ClientVM, "Address1", false, DataSourceUpdateMode.OnValidation, "");
			textBoxCity.DataBindings.Add("Text", ClientVM, "City", false, DataSourceUpdateMode.OnValidation, "");
			comboBoxProvinces.DataBindings.Add("SelectedItem", ClientVM, "Province", false, DataSourceUpdateMode.OnPropertyChanged, "");
			textBoxPostalCode.DataBindings.Add("Text", ClientVM, "PostalCode", false, DataSourceUpdateMode.OnValidation, "");
			textBoxYearToDateSale.DataBindings.Add("Text", ClientVM, "YTDSale", false, DataSourceUpdateMode.OnValidation, "");
			checkBoxCreditHold.DataBindings.Add("Checked", ClientVM, "CreditHold", false, DataSourceUpdateMode.OnValidation, "");
			textBoxNotes.DataBindings.Add("Text", ClientVM, "Notes", false, DataSourceUpdateMode.OnValidation, "");
			
		}


		private void buttonOK_Click(object sender, EventArgs e)
		{
			Client cl;
			string errorMessage = String.Empty;
			errorProvider.SetIconAlignment(buttonOK, ErrorIconAlignment.MiddleLeft);
			errorProvider.SetError(buttonOK, "");

			try
			{
				cl= ClientVM.GetDisplayClient();

				int rowsAffected = 0;

				if (callingButton != null)
				{
					if (callingButton.Contains("New"))
					{
						rowsAffected = ClientValidation.AddClient(cl);
					}
				}
				else
				{
					rowsAffected = ClientValidation.UpdateClient(cl);
				}

				if (rowsAffected < 0)
				{
					errorMessage = ClientValidation.ErrorMessage;
					this.DialogResult = DialogResult.None;
				}

				errorProvider.SetError(buttonOK, errorMessage);

			}
			catch (Exception)
			{
				throw;
			}

			if (DialogResult == DialogResult.OK)
			{
				this.Close();
				this.Dispose();
			}
		}
	}
}
