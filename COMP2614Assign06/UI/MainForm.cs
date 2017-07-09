using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLib.Common;
using BusinessLib.Business;
using System.Data.SqlClient;

namespace COMP2614Assign06.UI
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
			
			clientVM = new ClientViewModel(ClientValidation.GetClients());
			setupBindings();
			setupGridView(res);
			refreshStatsPanel();
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
			clientVM.SetDisplayClient(client);

			using (ClientEditDialog ced = new ClientEditDialog())
			{
				ced.ClientVM = clientVM;
				if (ced.ShowDialog() == DialogResult.OK)
				{
					bgw.RunWorkerAsync();
					refreshStatsPanel();
				}
			}
		}

		private void refreshStatsPanel()
		{
			labelYtdSale.Text =  res.TotalYTDSales.ToString();
			labelCreditHoldCount.Text =  res.CreditHoldCount.ToString();
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			Button buttonOrigin = (Button)sender;
			clientVM.SetDisplayClient(new Client(String.Empty, String.Empty, string.Empty, String.Empty, string.Empty, string.Empty, 0.0m, false, String.Empty));
			using (ClientEditDialog ced = new ClientEditDialog())
			{
				ced.ClientVM = clientVM;
				ced.callingButton = buttonOrigin.Text;
				ced.ShowDialog();
				bgw.RunWorkerAsync();
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			try
			{
				int currentRecord = dataGridViewClients.CurrentRow.Index;
				Client cl = clientVM.Clients[currentRecord];
				DeleteCurrentRecord(cl, checkBoxDeleteConfirmation.Checked);
			}
			catch (SqlException sqlEx)
			{
				MessageBox.Show("DB Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				throw;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Processing Error: " + ex.Message, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DeleteCurrentRecord(Client cl, bool confirmationRequired)
		{
			DialogResult response = DialogResult.None;
			if (confirmationRequired)
			{
				response = MessageBox.Show("You are about to Delete record with ID: " + cl.ClientCode + " ?\nAre you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			}
			else
			{
				DeleteRecord(cl);
			}

			if (response == DialogResult.Yes)
			{
				DeleteRecord(cl);
			}
		}

		private void DeleteRecord(Client cl)
		{
			ClientValidation.DeleteClient(cl);
			bgw.RunWorkerAsync();
		}
	}
}