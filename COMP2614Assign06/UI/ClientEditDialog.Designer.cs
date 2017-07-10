namespace COMP2614Assign06.UI
{
	partial class ClientEditDialog
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
			this.components = new System.ComponentModel.Container();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.checkBoxCreditHold = new System.Windows.Forms.CheckBox();
			this.textBoxNotes = new System.Windows.Forms.TextBox();
			this.labelNotes = new System.Windows.Forms.Label();
			this.textBoxCompanyName = new System.Windows.Forms.TextBox();
			this.labelCompanyName = new System.Windows.Forms.Label();
			this.textBoxAddress1 = new System.Windows.Forms.TextBox();
			this.labelAddress1 = new System.Windows.Forms.Label();
			this.labelProvince = new System.Windows.Forms.Label();
			this.textBoxPostalCode = new System.Windows.Forms.TextBox();
			this.labelPostalCode = new System.Windows.Forms.Label();
			this.textBoxYearToDateSale = new System.Windows.Forms.TextBox();
			this.labelYearToDateSale = new System.Windows.Forms.Label();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.labelCity = new System.Windows.Forms.Label();
			this.textBoxClientCode = new System.Windows.Forms.TextBox();
			this.labelClientCode = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.comboBoxProvinces = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(471, 288);
			this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(67, 26);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(543, 288);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(67, 26);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// checkBoxCreditHold
			// 
			this.checkBoxCreditHold.AutoSize = true;
			this.checkBoxCreditHold.Location = new System.Drawing.Point(333, 113);
			this.checkBoxCreditHold.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.checkBoxCreditHold.Name = "checkBoxCreditHold";
			this.checkBoxCreditHold.Size = new System.Drawing.Size(100, 21);
			this.checkBoxCreditHold.TabIndex = 33;
			this.checkBoxCreditHold.Text = "Credit Hold";
			this.checkBoxCreditHold.UseVisualStyleBackColor = true;
			// 
			// textBoxNotes
			// 
			this.textBoxNotes.Location = new System.Drawing.Point(441, 142);
			this.textBoxNotes.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.textBoxNotes.Multiline = true;
			this.textBoxNotes.Name = "textBoxNotes";
			this.textBoxNotes.Size = new System.Drawing.Size(163, 126);
			this.textBoxNotes.TabIndex = 32;
			// 
			// labelNotes
			// 
			this.labelNotes.AutoSize = true;
			this.labelNotes.Location = new System.Drawing.Point(329, 145);
			this.labelNotes.Name = "labelNotes";
			this.labelNotes.Size = new System.Drawing.Size(49, 17);
			this.labelNotes.TabIndex = 31;
			this.labelNotes.Text = "&Notes:";
			// 
			// textBoxCompanyName
			// 
			this.textBoxCompanyName.Location = new System.Drawing.Point(135, 47);
			this.textBoxCompanyName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.textBoxCompanyName.Name = "textBoxCompanyName";
			this.textBoxCompanyName.Size = new System.Drawing.Size(163, 22);
			this.textBoxCompanyName.TabIndex = 20;
			// 
			// labelCompanyName
			// 
			this.labelCompanyName.AutoSize = true;
			this.labelCompanyName.Location = new System.Drawing.Point(16, 50);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new System.Drawing.Size(112, 17);
			this.labelCompanyName.TabIndex = 19;
			this.labelCompanyName.Text = "&Company Name:";
			// 
			// textBoxAddress1
			// 
			this.textBoxAddress1.Location = new System.Drawing.Point(135, 79);
			this.textBoxAddress1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.textBoxAddress1.Name = "textBoxAddress1";
			this.textBoxAddress1.Size = new System.Drawing.Size(163, 22);
			this.textBoxAddress1.TabIndex = 22;
			// 
			// labelAddress1
			// 
			this.labelAddress1.AutoSize = true;
			this.labelAddress1.Location = new System.Drawing.Point(16, 81);
			this.labelAddress1.Name = "labelAddress1";
			this.labelAddress1.Size = new System.Drawing.Size(76, 17);
			this.labelAddress1.TabIndex = 21;
			this.labelAddress1.Text = "&Address 1:";
			// 
			// labelProvince
			// 
			this.labelProvince.AutoSize = true;
			this.labelProvince.Location = new System.Drawing.Point(329, 17);
			this.labelProvince.Name = "labelProvince";
			this.labelProvince.Size = new System.Drawing.Size(67, 17);
			this.labelProvince.TabIndex = 25;
			this.labelProvince.Text = "&Province:";
			// 
			// textBoxPostalCode
			// 
			this.textBoxPostalCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxPostalCode.Location = new System.Drawing.Point(441, 46);
			this.textBoxPostalCode.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.textBoxPostalCode.MaxLength = 7;
			this.textBoxPostalCode.Name = "textBoxPostalCode";
			this.textBoxPostalCode.Size = new System.Drawing.Size(163, 22);
			this.textBoxPostalCode.TabIndex = 28;
			// 
			// labelPostalCode
			// 
			this.labelPostalCode.AutoSize = true;
			this.labelPostalCode.Location = new System.Drawing.Point(329, 49);
			this.labelPostalCode.Name = "labelPostalCode";
			this.labelPostalCode.Size = new System.Drawing.Size(88, 17);
			this.labelPostalCode.TabIndex = 27;
			this.labelPostalCode.Text = "P&ostal Code:";
			// 
			// textBoxYearToDateSale
			// 
			this.textBoxYearToDateSale.Location = new System.Drawing.Point(441, 78);
			this.textBoxYearToDateSale.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.textBoxYearToDateSale.Name = "textBoxYearToDateSale";
			this.textBoxYearToDateSale.Size = new System.Drawing.Size(163, 22);
			this.textBoxYearToDateSale.TabIndex = 30;
			// 
			// labelYearToDateSale
			// 
			this.labelYearToDateSale.AutoSize = true;
			this.labelYearToDateSale.Location = new System.Drawing.Point(329, 81);
			this.labelYearToDateSale.Name = "labelYearToDateSale";
			this.labelYearToDateSale.Size = new System.Drawing.Size(72, 17);
			this.labelYearToDateSale.TabIndex = 29;
			this.labelYearToDateSale.Text = "YTD &Sale:";
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(135, 111);
			this.textBoxCity.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(163, 22);
			this.textBoxCity.TabIndex = 24;
			// 
			// labelCity
			// 
			this.labelCity.AutoSize = true;
			this.labelCity.Location = new System.Drawing.Point(16, 114);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(35, 17);
			this.labelCity.TabIndex = 23;
			this.labelCity.Text = "Ci&ty:";
			// 
			// textBoxClientCode
			// 
			this.textBoxClientCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxClientCode.Location = new System.Drawing.Point(135, 15);
			this.textBoxClientCode.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this.textBoxClientCode.MaxLength = 5;
			this.textBoxClientCode.Name = "textBoxClientCode";
			this.textBoxClientCode.ShortcutsEnabled = false;
			this.textBoxClientCode.Size = new System.Drawing.Size(163, 22);
			this.textBoxClientCode.TabIndex = 18;
			// 
			// labelClientCode
			// 
			this.labelClientCode.AutoSize = true;
			this.labelClientCode.Location = new System.Drawing.Point(16, 17);
			this.labelClientCode.Name = "labelClientCode";
			this.labelClientCode.Size = new System.Drawing.Size(80, 17);
			this.labelClientCode.TabIndex = 17;
			this.labelClientCode.Text = "Cli&ent Code";
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// comboBoxProvinces
			// 
			this.comboBoxProvinces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxProvinces.FormattingEnabled = true;
			this.comboBoxProvinces.Location = new System.Drawing.Point(441, 13);
			this.comboBoxProvinces.Name = "comboBoxProvinces";
			this.comboBoxProvinces.Size = new System.Drawing.Size(163, 24);
			this.comboBoxProvinces.TabIndex = 34;
			// 
			// ClientEditDialog
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(620, 324);
			this.Controls.Add(this.comboBoxProvinces);
			this.Controls.Add(this.checkBoxCreditHold);
			this.Controls.Add(this.textBoxNotes);
			this.Controls.Add(this.labelNotes);
			this.Controls.Add(this.textBoxCompanyName);
			this.Controls.Add(this.labelCompanyName);
			this.Controls.Add(this.textBoxAddress1);
			this.Controls.Add(this.labelAddress1);
			this.Controls.Add(this.labelProvince);
			this.Controls.Add(this.textBoxPostalCode);
			this.Controls.Add(this.labelPostalCode);
			this.Controls.Add(this.textBoxYearToDateSale);
			this.Controls.Add(this.labelYearToDateSale);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.textBoxClientCode);
			this.Controls.Add(this.labelClientCode);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ClientEditDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Client Edit Dialog";
			this.Load += new System.EventHandler(this.ClientEditDialog_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.CheckBox checkBoxCreditHold;
		private System.Windows.Forms.TextBox textBoxNotes;
		private System.Windows.Forms.Label labelNotes;
		private System.Windows.Forms.TextBox textBoxCompanyName;
		private System.Windows.Forms.Label labelCompanyName;
		private System.Windows.Forms.TextBox textBoxAddress1;
		private System.Windows.Forms.Label labelAddress1;
		private System.Windows.Forms.Label labelProvince;
		private System.Windows.Forms.TextBox textBoxPostalCode;
		private System.Windows.Forms.Label labelPostalCode;
		private System.Windows.Forms.TextBox textBoxYearToDateSale;
		private System.Windows.Forms.Label labelYearToDateSale;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.Label labelCity;
		private System.Windows.Forms.TextBox textBoxClientCode;
		private System.Windows.Forms.Label labelClientCode;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.ComboBox comboBoxProvinces;
	}
}