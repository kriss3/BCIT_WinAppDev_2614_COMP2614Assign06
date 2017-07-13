namespace COMP2614Assign06.UI
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.statusStripProgress = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.dataGridViewClients = new System.Windows.Forms.DataGridView();
			this.bgw = new System.ComponentModel.BackgroundWorker();
			this.buttonNew = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelCreditHoldCount = new System.Windows.Forms.Label();
			this.labelYtdSale = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxDeleteConfirmation = new System.Windows.Forms.CheckBox();
			this.statusStripProgress.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStripProgress
			// 
			this.statusStripProgress.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStripProgress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
			this.statusStripProgress.Location = new System.Drawing.Point(0, 489);
			this.statusStripProgress.Name = "statusStripProgress";
			this.statusStripProgress.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
			this.statusStripProgress.Size = new System.Drawing.Size(997, 25);
			this.statusStripProgress.TabIndex = 5;
			this.statusStripProgress.Text = "statusStrip1";
			// 
			// toolStripStatusLabelInfo
			// 
			this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
			this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(76, 20);
			this.toolStripStatusLabelInfo.Text = "Loading ...";
			this.toolStripStatusLabelInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			// 
			// dataGridViewClients
			// 
			this.dataGridViewClients.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridViewClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewClients.Location = new System.Drawing.Point(11, 11);
			this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridViewClients.Name = "dataGridViewClients";
			this.dataGridViewClients.RowTemplate.Height = 28;
			this.dataGridViewClients.RowTemplate.ReadOnly = true;
			this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewClients.Size = new System.Drawing.Size(974, 357);
			this.dataGridViewClients.TabIndex = 6;
			this.dataGridViewClients.DoubleClick += new System.EventHandler(this.dataGridViewClients_DoubleClick);
			// 
			// bgw
			// 
			this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
			this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
			// 
			// buttonNew
			// 
			this.buttonNew.Location = new System.Drawing.Point(748, 450);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(75, 23);
			this.buttonNew.TabIndex = 2;
			this.buttonNew.Text = "&New";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(829, 449);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete.TabIndex = 1;
			this.buttonDelete.Text = "&Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Location = new System.Drawing.Point(910, 450);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(75, 23);
			this.buttonEdit.TabIndex = 0;
			this.buttonEdit.Text = "&Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelCreditHoldCount);
			this.groupBox1.Controls.Add(this.labelYtdSale);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(218, 373);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(270, 100);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "&Grid Stats:";
			// 
			// labelCreditHoldCount
			// 
			this.labelCreditHoldCount.AutoSize = true;
			this.labelCreditHoldCount.Location = new System.Drawing.Point(157, 68);
			this.labelCreditHoldCount.Name = "labelCreditHoldCount";
			this.labelCreditHoldCount.Size = new System.Drawing.Size(103, 20);
			this.labelCreditHoldCount.TabIndex = 3;
			this.labelCreditHoldCount.Text = "<CH Count>";
			this.labelCreditHoldCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelYtdSale
			// 
			this.labelYtdSale.AutoSize = true;
			this.labelYtdSale.Location = new System.Drawing.Point(157, 28);
			this.labelYtdSale.Name = "labelYtdSale";
			this.labelYtdSale.Size = new System.Drawing.Size(100, 20);
			this.labelYtdSale.TabIndex = 1;
			this.labelYtdSale.Text = "<YTD Sale>";
			this.labelYtdSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Credit &Hold Count:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "YTD &Sale:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBoxDeleteConfirmation);
			this.groupBox2.Location = new System.Drawing.Point(12, 373);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 100);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "&Operations:";
			// 
			// checkBoxDeleteConfirmation
			// 
			this.checkBoxDeleteConfirmation.AutoSize = true;
			this.checkBoxDeleteConfirmation.Checked = true;
			this.checkBoxDeleteConfirmation.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxDeleteConfirmation.Location = new System.Drawing.Point(7, 24);
			this.checkBoxDeleteConfirmation.Name = "checkBoxDeleteConfirmation";
			this.checkBoxDeleteConfirmation.Size = new System.Drawing.Size(140, 24);
			this.checkBoxDeleteConfirmation.TabIndex = 0;
			this.checkBoxDeleteConfirmation.Text = "&Confirm delete";
			this.checkBoxDeleteConfirmation.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonEdit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(997, 514);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonNew);
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
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStripProgress;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
		private System.Windows.Forms.DataGridView dataGridViewClients;
		private System.ComponentModel.BackgroundWorker bgw;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelCreditHoldCount;
		private System.Windows.Forms.Label labelYtdSale;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBoxDeleteConfirmation;
	}
}

