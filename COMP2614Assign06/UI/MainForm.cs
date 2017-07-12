using System;
using System.ComponentModel;
using System.Windows.Forms;

using BusinessLib.Common;
using BusinessLib.Business;
using System.Data.SqlClient;

namespace COMP2614Assign06.UI
{
	/// <summary>
	/// Main application starter;
	/// @see https://github.com/kriss3/BCIT_WinAppDev_2614_COMP2614Assign06.git
	/// @Author: Krzysztof Szczurowski
	/// @Date: June  2017
	/// </summary>
	public partial class MainForm : Form
	{
		private ClientCollection resource;
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
			resource = (ClientCollection)e.Result;
			
			clientVM = new ClientViewModel(ClientValidation.GetClients());
			setupBindings();
			refreshStatsPanel();
			toolStripStatusLabelInfo.Text = "Loaded";
		}

		private void setupBindings()
		{
			dataGridViewClients.AutoGenerateColumns = true;
			dataGridViewClients.DataSource = clientVM.Clients;
		}

		private void dataGridViewClients_DoubleClick(object sender, EventArgs e)
		{
			displayClient();
		}

		private void refreshStatsPanel()
		{
			labelYtdSale.Text =  resource.TotalYTDSales.ToString();
			labelCreditHoldCount.Text =  resource.CreditHoldCount.ToString();
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			Button buttonOrigin = (Button)sender;
			clientVM.SetDisplayClient(new Client(String.Empty, String.Empty, string.Empty, string.Empty, "<Select Province>", string.Empty, 0.0m, false, String.Empty));
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

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			displayClient();
		}

		private void displayClient()
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
	}
}