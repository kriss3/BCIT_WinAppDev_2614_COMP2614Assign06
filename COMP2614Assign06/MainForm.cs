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
		private ClientCollection res;
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
			res = (ClientCollection)e.Result;
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
			dataGridViewClients.AutoGenerateColumns = true;
			dataGridViewClients.DataSource = clientVM.Clients;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This is where Database will be updated\nwith new values !!!", "Not Implemented Functionality", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
		}

		private void dataGridViewClients_DoubleClick(object sender, EventArgs e)
		{
			int index = dataGridViewClients.CurrentRow.Index;
			Client client = clientVM.Clients[index];
			clientVM.SetDisplayProduct(client);


			ClientEditDialog ced = new ClientEditDialog();
			ced.ClientVM = clientVM;
			ced.ShowDialog();
		}

		private void buttonStats_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Total YTD Sale: {res.TotalYTDSales}\nTotal Credit Hold: {res.CreditHoldCount}",
				"Results Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}