namespace COMP2614Assign06
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.statusStripProgress = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.dataGridViewClients = new System.Windows.Forms.DataGridView();
			this.labelClientCode = new System.Windows.Forms.Label();
			this.textBoxClientCode = new System.Windows.Forms.TextBox();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.labelCity = new System.Windows.Forms.Label();
			this.textBoxYearToDateSale = new System.Windows.Forms.TextBox();
			this.labelYearToDateSale = new System.Windows.Forms.Label();
			this.textBoxPostalCode = new System.Windows.Forms.TextBox();
			this.labelPostalCode = new System.Windows.Forms.Label();
			this.textBoxProvince = new System.Windows.Forms.TextBox();
			this.labelProvince = new System.Windows.Forms.Label();
			this.textBoxAddress1 = new System.Windows.Forms.TextBox();
			this.labelAddress1 = new System.Windows.Forms.Label();
			this.textBoxCompanyName = new System.Windows.Forms.TextBox();
			this.labelCompanyName = new System.Windows.Forms.Label();
			this.textBoxNotes = new System.Windows.Forms.TextBox();
			this.labelNotes = new System.Windows.Forms.Label();
			this.checkBoxCreditHold = new System.Windows.Forms.CheckBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.bgw = new System.ComponentModel.BackgroundWorker();
			this.statusStripProgress.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStripProgress
			// 
			this.statusStripProgress.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStripProgress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
			this.statusStripProgress.Location = new System.Drawing.Point(0, 574);
			this.statusStripProgress.Name = "statusStripProgress";
			this.statusStripProgress.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
			this.statusStripProgress.Size = new System.Drawing.Size(983, 22);
			this.statusStripProgress.TabIndex = 19;
			this.statusStripProgress.Text = "statusStrip1";
			// 
			// toolStripStatusLabelInfo
			// 
			this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
			this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(62, 17);
			this.toolStripStatusLabelInfo.Text = "Loading ...";
			this.toolStripStatusLabelInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			// 
			// dataGridViewClients
			// 
			this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewClients.Location = new System.Drawing.Point(11, 265);
			this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridViewClients.Name = "dataGridViewClients";
			this.dataGridViewClients.RowTemplate.Height = 28;
			this.dataGridViewClients.RowTemplate.ReadOnly = true;
			this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewClients.Size = new System.Drawing.Size(960, 302);
			this.dataGridViewClients.TabIndex = 18;
			this.dataGridViewClients.SelectionChanged += new System.EventHandler(this.dataGridViewClients_SelectionChanged);
			// 
			// labelClientCode
			// 
			this.labelClientCode.AutoSize = true;
			this.labelClientCode.Location = new System.Drawing.Point(28, 33);
			this.labelClientCode.Name = "labelClientCode";
			this.labelClientCode.Size = new System.Drawing.Size(77, 16);
			this.labelClientCode.TabIndex = 0;
			this.labelClientCode.Text = "Cli&ent Code";
			// 
			// textBoxClientCode
			// 
			this.textBoxClientCode.Location = new System.Drawing.Point(146, 30);
			this.textBoxClientCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxClientCode.Name = "textBoxClientCode";
			this.textBoxClientCode.Size = new System.Drawing.Size(141, 22);
			this.textBoxClientCode.TabIndex = 1;
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(146, 117);
			this.textBoxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(141, 22);
			this.textBoxCity.TabIndex = 7;
			// 
			// labelCity
			// 
			this.labelCity.AutoSize = true;
			this.labelCity.Location = new System.Drawing.Point(28, 119);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(33, 16);
			this.labelCity.TabIndex = 6;
			this.labelCity.Text = "Ci&ty:";
			// 
			// textBoxYearToDateSale
			// 
			this.textBoxYearToDateSale.Location = new System.Drawing.Point(402, 89);
			this.textBoxYearToDateSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxYearToDateSale.Name = "textBoxYearToDateSale";
			this.textBoxYearToDateSale.Size = new System.Drawing.Size(141, 22);
			this.textBoxYearToDateSale.TabIndex = 13;
			// 
			// labelYearToDateSale
			// 
			this.labelYearToDateSale.AutoSize = true;
			this.labelYearToDateSale.Location = new System.Drawing.Point(308, 90);
			this.labelYearToDateSale.Name = "labelYearToDateSale";
			this.labelYearToDateSale.Size = new System.Drawing.Size(70, 16);
			this.labelYearToDateSale.TabIndex = 12;
			this.labelYearToDateSale.Text = "YTD &Sale:";
			// 
			// textBoxPostalCode
			// 
			this.textBoxPostalCode.Location = new System.Drawing.Point(402, 58);
			this.textBoxPostalCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPostalCode.Name = "textBoxPostalCode";
			this.textBoxPostalCode.Size = new System.Drawing.Size(141, 22);
			this.textBoxPostalCode.TabIndex = 11;
			// 
			// labelPostalCode
			// 
			this.labelPostalCode.AutoSize = true;
			this.labelPostalCode.Location = new System.Drawing.Point(308, 60);
			this.labelPostalCode.Name = "labelPostalCode";
			this.labelPostalCode.Size = new System.Drawing.Size(85, 16);
			this.labelPostalCode.TabIndex = 10;
			this.labelPostalCode.Text = "P&ostal Code:";
			// 
			// textBoxProvince
			// 
			this.textBoxProvince.Location = new System.Drawing.Point(402, 28);
			this.textBoxProvince.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxProvince.Name = "textBoxProvince";
			this.textBoxProvince.Size = new System.Drawing.Size(141, 22);
			this.textBoxProvince.TabIndex = 9;
			// 
			// labelProvince
			// 
			this.labelProvince.AutoSize = true;
			this.labelProvince.Location = new System.Drawing.Point(308, 30);
			this.labelProvince.Name = "labelProvince";
			this.labelProvince.Size = new System.Drawing.Size(64, 16);
			this.labelProvince.TabIndex = 8;
			this.labelProvince.Text = "&Province:";
			// 
			// textBoxAddress1
			// 
			this.textBoxAddress1.Location = new System.Drawing.Point(146, 88);
			this.textBoxAddress1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxAddress1.Name = "textBoxAddress1";
			this.textBoxAddress1.Size = new System.Drawing.Size(141, 22);
			this.textBoxAddress1.TabIndex = 5;
			// 
			// labelAddress1
			// 
			this.labelAddress1.AutoSize = true;
			this.labelAddress1.Location = new System.Drawing.Point(28, 91);
			this.labelAddress1.Name = "labelAddress1";
			this.labelAddress1.Size = new System.Drawing.Size(72, 16);
			this.labelAddress1.TabIndex = 4;
			this.labelAddress1.Text = "&Address 1:";
			// 
			// textBoxCompanyName
			// 
			this.textBoxCompanyName.Location = new System.Drawing.Point(146, 59);
			this.textBoxCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxCompanyName.Name = "textBoxCompanyName";
			this.textBoxCompanyName.Size = new System.Drawing.Size(141, 22);
			this.textBoxCompanyName.TabIndex = 3;
			// 
			// labelCompanyName
			// 
			this.labelCompanyName.AutoSize = true;
			this.labelCompanyName.Location = new System.Drawing.Point(28, 61);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new System.Drawing.Size(109, 16);
			this.labelCompanyName.TabIndex = 2;
			this.labelCompanyName.Text = "&Company Name:";
			// 
			// textBoxNotes
			// 
			this.textBoxNotes.Location = new System.Drawing.Point(402, 119);
			this.textBoxNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxNotes.Multiline = true;
			this.textBoxNotes.Name = "textBoxNotes";
			this.textBoxNotes.Size = new System.Drawing.Size(141, 94);
			this.textBoxNotes.TabIndex = 15;
			// 
			// labelNotes
			// 
			this.labelNotes.AutoSize = true;
			this.labelNotes.Location = new System.Drawing.Point(308, 122);
			this.labelNotes.Name = "labelNotes";
			this.labelNotes.Size = new System.Drawing.Size(47, 16);
			this.labelNotes.TabIndex = 14;
			this.labelNotes.Text = "&Notes:";
			// 
			// checkBoxCreditHold
			// 
			this.checkBoxCreditHold.AutoSize = true;
			this.checkBoxCreditHold.Location = new System.Drawing.Point(312, 226);
			this.checkBoxCreditHold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.checkBoxCreditHold.Name = "checkBoxCreditHold";
			this.checkBoxCreditHold.Size = new System.Drawing.Size(94, 20);
			this.checkBoxCreditHold.TabIndex = 16;
			this.checkBoxCreditHold.Text = "Credit Hold";
			this.checkBoxCreditHold.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSave.Location = new System.Drawing.Point(476, 219);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(67, 27);
			this.buttonSave.TabIndex = 17;
			this.buttonSave.Text = "Sa&ve";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// bgw
			// 
			this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
			this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(983, 596);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.checkBoxCreditHold);
			this.Controls.Add(this.textBoxNotes);
			this.Controls.Add(this.labelNotes);
			this.Controls.Add(this.textBoxCompanyName);
			this.Controls.Add(this.labelCompanyName);
			this.Controls.Add(this.textBoxAddress1);
			this.Controls.Add(this.labelAddress1);
			this.Controls.Add(this.textBoxProvince);
			this.Controls.Add(this.labelProvince);
			this.Controls.Add(this.textBoxPostalCode);
			this.Controls.Add(this.labelPostalCode);
			this.Controls.Add(this.textBoxYearToDateSale);
			this.Controls.Add(this.labelYearToDateSale);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.textBoxClientCode);
			this.Controls.Add(this.labelClientCode);
			this.Controls.Add(this.dataGridViewClients);
			this.Controls.Add(this.statusStripProgress);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Data Binding Assignment 6";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.statusStripProgress.ResumeLayout(false);
			this.statusStripProgress.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStripProgress;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
		private System.Windows.Forms.DataGridView dataGridViewClients;
		private System.Windows.Forms.Label labelClientCode;
		private System.Windows.Forms.TextBox textBoxClientCode;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.Label labelCity;
		private System.Windows.Forms.TextBox textBoxYearToDateSale;
		private System.Windows.Forms.Label labelYearToDateSale;
		private System.Windows.Forms.TextBox textBoxPostalCode;
		private System.Windows.Forms.Label labelPostalCode;
		private System.Windows.Forms.TextBox textBoxProvince;
		private System.Windows.Forms.Label labelProvince;
		private System.Windows.Forms.TextBox textBoxAddress1;
		private System.Windows.Forms.Label labelAddress1;
		private System.Windows.Forms.TextBox textBoxCompanyName;
		private System.Windows.Forms.Label labelCompanyName;
		private System.Windows.Forms.TextBox textBoxNotes;
		private System.Windows.Forms.Label labelNotes;
		private System.Windows.Forms.CheckBox checkBoxCreditHold;
		private System.Windows.Forms.Button buttonSave;
		private System.ComponentModel.BackgroundWorker bgw;
	}
}

