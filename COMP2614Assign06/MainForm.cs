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
	public partial class MainForm : Form
	{

		private ClientViewModel clientVM;
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.Text = this.Text + " | current user: " + Helper.GetTitle();
			bgw.RunWorkerAsync();
			
		}
		private void bgw_DoWork(object sender, DoWorkEventArgs e)
		{
			e.Result = Helper.GetData();
		}
		private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			var res = (ClientCollection)e.Result;
			clientVM = new ClientViewModel(res);
			setupBindings();
			setupGridView(res);
			toolStripStatusLabelInfo.Text = "Loaded";
		}

		private void setupGridView(ClientCollection clients)
		{
			//setup your grid in case u disable AutoGenerateColumns !!!
		}

		private void setupBindings()
		{
			textBoxClientCode.DataBindings.Add("Text", clientVM, "ClientCode", false, DataSourceUpdateMode.OnValidation, "");
			textBoxCompanyName.DataBindings.Add("Text", clientVM, "CompanyName", false, DataSourceUpdateMode.OnValidation, "");
			textBoxAddress1.DataBindings.Add("Text", clientVM, "Address1", false, DataSourceUpdateMode.OnValidation, "");
			textBoxCity.DataBindings.Add("Text", clientVM, "City", false, DataSourceUpdateMode.OnValidation, "");
			textBoxProvince.DataBindings.Add("Text", clientVM, "Province", false, DataSourceUpdateMode.OnValidation, "");
			textBoxPostalCode.DataBindings.Add("Text", clientVM, "PostalCode", false, DataSourceUpdateMode.OnValidation, "");
			textBoxYearToDateSale.DataBindings.Add("Text", clientVM, "YTDSale", false, DataSourceUpdateMode.OnValidation, "");
			checkBoxCreditHold.DataBindings.Add("Checked", clientVM, "CreditHold", false, DataSourceUpdateMode.OnValidation, "");
			textBoxNotes.DataBindings.Add("Text", clientVM, "Notes", false, DataSourceUpdateMode.OnValidation, "");


			dataGridViewClients.AutoGenerateColumns = true;
			dataGridViewClients.DataSource = clientVM.Clients;
		}

		private void dataGridViewClients_SelectionChanged(object sender, EventArgs e)
		{
			int index = dataGridViewClients.CurrentRow.Index;
			Client client = clientVM.Clients[index];
			clientVM.SetDisplayProduct(client);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This is where Database will be updated\nwith new values !!!", "Not Implemented Functionality", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
		}
	}
}