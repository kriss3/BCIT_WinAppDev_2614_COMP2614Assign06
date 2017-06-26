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
			this.buttonSave = new System.Windows.Forms.Button();
			this.bgw = new System.ComponentModel.BackgroundWorker();
			this.buttonStats = new System.Windows.Forms.Button();
			this.statusStripProgress.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStripProgress
			// 
			this.statusStripProgress.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStripProgress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
			this.statusStripProgress.Location = new System.Drawing.Point(0, 492);
			this.statusStripProgress.Name = "statusStripProgress";
			this.statusStripProgress.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
			this.statusStripProgress.Size = new System.Drawing.Size(997, 22);
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
			this.dataGridViewClients.Location = new System.Drawing.Point(11, 11);
			this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridViewClients.Name = "dataGridViewClients";
			this.dataGridViewClients.RowTemplate.Height = 28;
			this.dataGridViewClients.RowTemplate.ReadOnly = true;
			this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewClients.Size = new System.Drawing.Size(960, 421);
			this.dataGridViewClients.TabIndex = 18;
			this.dataGridViewClients.DoubleClick += new System.EventHandler(this.dataGridViewClients_DoubleClick);
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSave.Location = new System.Drawing.Point(904, 452);
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
			// buttonStats
			// 
			this.buttonStats.Location = new System.Drawing.Point(823, 452);
			this.buttonStats.Name = "buttonStats";
			this.buttonStats.Size = new System.Drawing.Size(75, 27);
			this.buttonStats.TabIndex = 20;
			this.buttonStats.Text = "Stats";
			this.buttonStats.UseVisualStyleBackColor = true;
			this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(997, 514);
			this.Controls.Add(this.buttonStats);
			this.Controls.Add(this.buttonSave);
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
		private System.Windows.Forms.Button buttonSave;
		private System.ComponentModel.BackgroundWorker bgw;
		private System.Windows.Forms.Button buttonStats;
	}
}

