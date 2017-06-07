namespace SvnPatcher
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtPatchFile = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnRun = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.cbDryRun = new System.Windows.Forms.CheckBox();
			this.btnCommit = new System.Windows.Forms.Button();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnCleanup = new System.Windows.Forms.Button();
			this.btnRevert = new System.Windows.Forms.Button();
			this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.SVNDirectory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Browse = new System.Windows.Forms.DataGridViewButtonColumn();
			this.BugId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewLinkColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.SVNDirectory,
            this.Browse,
            this.BugId,
            this.Status});
			this.dataGridView1.Location = new System.Drawing.Point(0, 28);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(749, 275);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// txtPatchFile
			// 
			this.txtPatchFile.Location = new System.Drawing.Point(64, 16);
			this.txtPatchFile.Name = "txtPatchFile";
			this.txtPatchFile.Size = new System.Drawing.Size(397, 20);
			this.txtPatchFile.TabIndex = 1;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(467, 15);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(67, 23);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnRun
			// 
			this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRun.Location = new System.Drawing.Point(639, 15);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(104, 23);
			this.btnRun.TabIndex = 3;
			this.btnRun.Text = "Patch Selected";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Patch File";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(0, -1);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add Row";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// cbDryRun
			// 
			this.cbDryRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbDryRun.AutoSize = true;
			this.cbDryRun.Location = new System.Drawing.Point(577, 19);
			this.cbDryRun.Name = "cbDryRun";
			this.cbDryRun.Size = new System.Drawing.Size(65, 17);
			this.cbDryRun.TabIndex = 6;
			this.cbDryRun.Text = "Dry Run";
			this.cbDryRun.UseVisualStyleBackColor = true;
			// 
			// btnCommit
			// 
			this.btnCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCommit.Location = new System.Drawing.Point(639, 108);
			this.btnCommit.Name = "btnCommit";
			this.btnCommit.Size = new System.Drawing.Size(104, 23);
			this.btnCommit.TabIndex = 7;
			this.btnCommit.Text = "Commit Selected";
			this.btnCommit.UseVisualStyleBackColor = true;
			this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
			// 
			// txtMessage
			// 
			this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMessage.Location = new System.Drawing.Point(6, 32);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(627, 99);
			this.txtMessage.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Log Message";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnRun);
			this.groupBox1.Controls.Add(this.txtPatchFile);
			this.groupBox1.Controls.Add(this.btnBrowse);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbDryRun);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 317);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(749, 49);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Patching";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.txtMessage);
			this.groupBox2.Controls.Add(this.btnCommit);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(0, 434);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(749, 137);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Committing";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.btnRevert);
			this.groupBox3.Controls.Add(this.btnCleanup);
			this.groupBox3.Location = new System.Drawing.Point(0, 370);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(749, 58);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Maintenance";
			// 
			// btnCleanup
			// 
			this.btnCleanup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCleanup.Location = new System.Drawing.Point(639, 19);
			this.btnCleanup.Name = "btnCleanup";
			this.btnCleanup.Size = new System.Drawing.Size(104, 23);
			this.btnCleanup.TabIndex = 0;
			this.btnCleanup.Text = "Cleanup Selected";
			this.btnCleanup.UseVisualStyleBackColor = true;
			this.btnCleanup.Click += new System.EventHandler(this.btnCleanup_Click);
			// 
			// btnRevert
			// 
			this.btnRevert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRevert.Location = new System.Drawing.Point(531, 19);
			this.btnRevert.Name = "btnRevert";
			this.btnRevert.Size = new System.Drawing.Size(102, 23);
			this.btnRevert.TabIndex = 1;
			this.btnRevert.Text = "Revert Selected";
			this.btnRevert.UseVisualStyleBackColor = true;
			this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
			// 
			// Selected
			// 
			this.Selected.HeaderText = "";
			this.Selected.Name = "Selected";
			this.Selected.TrueValue = "";
			this.Selected.Width = 20;
			// 
			// SVNDirectory
			// 
			this.SVNDirectory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SVNDirectory.HeaderText = "SVN Working Directory";
			this.SVNDirectory.Name = "SVNDirectory";
			// 
			// Browse
			// 
			this.Browse.HeaderText = "";
			this.Browse.Name = "Browse";
			this.Browse.Text = "Browse...";
			this.Browse.UseColumnTextForButtonValue = true;
			// 
			// BugId
			// 
			this.BugId.HeaderText = "Bug Id";
			this.BugId.Name = "BugId";
			// 
			// Status
			// 
			this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Status.HeaderText = "";
			this.Status.Name = "Status";
			this.Status.Width = 5;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(749, 568);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnAdd);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(765, 0);
			this.Name = "Main";
			this.Text = "SVN Patcher";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtPatchFile;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.CheckBox cbDryRun;
		private System.Windows.Forms.Button btnCommit;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnRevert;
		private System.Windows.Forms.Button btnCleanup;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
		private System.Windows.Forms.DataGridViewTextBoxColumn SVNDirectory;
		private System.Windows.Forms.DataGridViewButtonColumn Browse;
		private System.Windows.Forms.DataGridViewTextBoxColumn BugId;
		private System.Windows.Forms.DataGridViewLinkColumn Status;
	}
}

