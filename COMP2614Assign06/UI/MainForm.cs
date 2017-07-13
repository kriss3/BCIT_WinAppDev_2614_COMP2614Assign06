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
		private int currentIndex;

		public MainForm()
		{
			InitializeComponent();
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			this.Text = this.Text + " | current user: " + Helper.GetTitle();
			bgw.RunWorkerAsync();
		}
		/// <summary>
		/// Method to Run long running task;
		/// </summary>
		/// <param name="sender">RunWorkrAsync()</param>
		/// <param name="e"></param>
		private void bgw_DoWork(object sender, DoWorkEventArgs e)
		{
			toolStripStatusLabelInfo.Text = "Loading...";
			e.Result = ClientValidation.GetClients();
		}
		/// <summary>
		/// Getting results from the background running thread;
		/// Hadling selected row possioning (vScrolling) after data reload (preserving vertical possition and currect cell possition)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e">results of the background runnig thread</param>
		private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			resource = (ClientCollection)e.Result;
			clientVM = new ClientViewModel(ClientValidation.GetClients());
			setupBindings();
			refreshStatsPanel();
			toolStripStatusLabelInfo.Text = "Loaded";
			dataGridViewClients.ClearSelection();
			dataGridViewClients.CurrentRow.Selected = false;
			dataGridViewClients.Rows[currentIndex].Selected = true;
			dataGridViewClients.CurrentCell = dataGridViewClients[0, currentIndex];
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
				MessageBox.Show($"DB Error: {sqlEx.Message}\nContact Admin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
		private void buttonEdit_Click(object sender, EventArgs e)
		{
			displayClient();
		}
		private void refreshStatsPanel()
		{
			labelYtdSale.Text = resource.TotalYTDSales.ToString();
			labelCreditHoldCount.Text = resource.CreditHoldCount.ToString();
		}
		private void DeleteRecord(Client cl)
		{
			ClientValidation.DeleteClient(cl);
			bgw.RunWorkerAsync();
		}
		/// <summary>
		/// Setup viewModel and open Modal Form with the current record data;
		/// </summary>
		private void displayClient()
		{
			currentIndex = dataGridViewClients.CurrentRow.Index;
			Client client = clientVM.Clients[currentIndex];
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