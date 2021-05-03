namespace UPS.EmployeeManagement.UI
{
  partial class EmployeeManagement
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
			this.dgEmployees = new System.Windows.Forms.DataGridView();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.lblCurrentPage = new System.Windows.Forms.Label();
			this.txtFilterName = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnEditEmployee = new System.Windows.Forms.Button();
			this.btnDeleteEmployee = new System.Windows.Forms.Button();
			this.btnAddEmployee = new System.Windows.Forms.Button();
			this.gbFilter = new System.Windows.Forms.GroupBox();
			this.ddlFilterStatus = new System.Windows.Forms.ComboBox();
			this.lblFilterStatus = new System.Windows.Forms.Label();
			this.ddlFilterGender = new System.Windows.Forms.ComboBox();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblEmailFilter = new System.Windows.Forms.Label();
			this.txtFilterEmail = new System.Windows.Forms.TextBox();
			this.lblNameFilter = new System.Windows.Forms.Label();
			this.lblFeedback = new System.Windows.Forms.Label();
			this.btnExport = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
			this.gbFilter.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgEmployees
			// 
			this.dgEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgEmployees.Location = new System.Drawing.Point(13, 95);
			this.dgEmployees.MultiSelect = false;
			this.dgEmployees.Name = "dgEmployees";
			this.dgEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgEmployees.Size = new System.Drawing.Size(853, 466);
			this.dgEmployees.TabIndex = 0;
			this.dgEmployees.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgEmployees_DataBindingComplete);
			this.dgEmployees.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployees_RowEnter);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Enabled = false;
			this.btnNext.Location = new System.Drawing.Point(806, 567);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(60, 23);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "Next >>";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrevious.Enabled = false;
			this.btnPrevious.Location = new System.Drawing.Point(656, 567);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(62, 23);
			this.btnPrevious.TabIndex = 3;
			this.btnPrevious.Text = "<< Prev";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// lblCurrentPage
			// 
			this.lblCurrentPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCurrentPage.AutoSize = true;
			this.lblCurrentPage.Location = new System.Drawing.Point(723, 572);
			this.lblCurrentPage.Name = "lblCurrentPage";
			this.lblCurrentPage.Size = new System.Drawing.Size(77, 13);
			this.lblCurrentPage.TabIndex = 4;
			this.lblCurrentPage.Text = "Page: 1 of 100";
			// 
			// txtFilterName
			// 
			this.txtFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFilterName.Location = new System.Drawing.Point(52, 19);
			this.txtFilterName.Name = "txtFilterName";
			this.txtFilterName.Size = new System.Drawing.Size(192, 20);
			this.txtFilterName.TabIndex = 5;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(771, 17);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(74, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Apply Filter";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnEditEmployee
			// 
			this.btnEditEmployee.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.btnEditEmployee.Location = new System.Drawing.Point(109, 12);
			this.btnEditEmployee.Name = "btnEditEmployee";
			this.btnEditEmployee.Size = new System.Drawing.Size(91, 23);
			this.btnEditEmployee.TabIndex = 7;
			this.btnEditEmployee.Text = "Edit Employee";
			this.btnEditEmployee.UseVisualStyleBackColor = true;
			this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
			// 
			// btnDeleteEmployee
			// 
			this.btnDeleteEmployee.ForeColor = System.Drawing.Color.Red;
			this.btnDeleteEmployee.Location = new System.Drawing.Point(206, 12);
			this.btnDeleteEmployee.Name = "btnDeleteEmployee";
			this.btnDeleteEmployee.Size = new System.Drawing.Size(91, 23);
			this.btnDeleteEmployee.TabIndex = 8;
			this.btnDeleteEmployee.Text = "Delete Employee";
			this.btnDeleteEmployee.UseVisualStyleBackColor = true;
			this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
			// 
			// btnAddEmployee
			// 
			this.btnAddEmployee.ForeColor = System.Drawing.Color.DarkGreen;
			this.btnAddEmployee.Location = new System.Drawing.Point(12, 12);
			this.btnAddEmployee.Name = "btnAddEmployee";
			this.btnAddEmployee.Size = new System.Drawing.Size(91, 23);
			this.btnAddEmployee.TabIndex = 9;
			this.btnAddEmployee.Text = "Add Employee";
			this.btnAddEmployee.UseVisualStyleBackColor = true;
			this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
			// 
			// gbFilter
			// 
			this.gbFilter.Controls.Add(this.ddlFilterStatus);
			this.gbFilter.Controls.Add(this.lblFilterStatus);
			this.gbFilter.Controls.Add(this.ddlFilterGender);
			this.gbFilter.Controls.Add(this.lblGender);
			this.gbFilter.Controls.Add(this.lblEmailFilter);
			this.gbFilter.Controls.Add(this.txtFilterEmail);
			this.gbFilter.Controls.Add(this.lblNameFilter);
			this.gbFilter.Controls.Add(this.txtFilterName);
			this.gbFilter.Controls.Add(this.btnSearch);
			this.gbFilter.Location = new System.Drawing.Point(12, 41);
			this.gbFilter.Name = "gbFilter";
			this.gbFilter.Size = new System.Drawing.Size(851, 48);
			this.gbFilter.TabIndex = 10;
			this.gbFilter.TabStop = false;
			this.gbFilter.Text = "Filter";
			// 
			// ddlFilterStatus
			// 
			this.ddlFilterStatus.FormattingEnabled = true;
			this.ddlFilterStatus.Items.AddRange(new object[] {
            "Select...",
            "Active",
            "Inactive"});
			this.ddlFilterStatus.Location = new System.Drawing.Point(676, 18);
			this.ddlFilterStatus.Name = "ddlFilterStatus";
			this.ddlFilterStatus.Size = new System.Drawing.Size(80, 21);
			this.ddlFilterStatus.TabIndex = 17;
			// 
			// lblFilterStatus
			// 
			this.lblFilterStatus.AutoSize = true;
			this.lblFilterStatus.Location = new System.Drawing.Point(624, 23);
			this.lblFilterStatus.Name = "lblFilterStatus";
			this.lblFilterStatus.Size = new System.Drawing.Size(40, 13);
			this.lblFilterStatus.TabIndex = 16;
			this.lblFilterStatus.Text = "Status:";
			// 
			// ddlFilterGender
			// 
			this.ddlFilterGender.FormattingEnabled = true;
			this.ddlFilterGender.Items.AddRange(new object[] {
            "Select...",
            "Male",
            "Female"});
			this.ddlFilterGender.Location = new System.Drawing.Point(538, 18);
			this.ddlFilterGender.Name = "ddlFilterGender";
			this.ddlFilterGender.Size = new System.Drawing.Size(80, 21);
			this.ddlFilterGender.TabIndex = 15;
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Location = new System.Drawing.Point(486, 23);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(45, 13);
			this.lblGender.TabIndex = 14;
			this.lblGender.Text = "Gender:";
			// 
			// lblEmailFilter
			// 
			this.lblEmailFilter.AutoSize = true;
			this.lblEmailFilter.Location = new System.Drawing.Point(250, 22);
			this.lblEmailFilter.Name = "lblEmailFilter";
			this.lblEmailFilter.Size = new System.Drawing.Size(32, 13);
			this.lblEmailFilter.TabIndex = 9;
			this.lblEmailFilter.Text = "Email";
			// 
			// txtFilterEmail
			// 
			this.txtFilterEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFilterEmail.Location = new System.Drawing.Point(288, 20);
			this.txtFilterEmail.Name = "txtFilterEmail";
			this.txtFilterEmail.Size = new System.Drawing.Size(192, 20);
			this.txtFilterEmail.TabIndex = 8;
			// 
			// lblNameFilter
			// 
			this.lblNameFilter.AutoSize = true;
			this.lblNameFilter.Location = new System.Drawing.Point(11, 22);
			this.lblNameFilter.Name = "lblNameFilter";
			this.lblNameFilter.Size = new System.Drawing.Size(35, 13);
			this.lblNameFilter.TabIndex = 7;
			this.lblNameFilter.Text = "Name";
			// 
			// lblFeedback
			// 
			this.lblFeedback.AutoSize = true;
			this.lblFeedback.Location = new System.Drawing.Point(12, 572);
			this.lblFeedback.Name = "lblFeedback";
			this.lblFeedback.Size = new System.Drawing.Size(16, 13);
			this.lblFeedback.TabIndex = 11;
			this.lblFeedback.Text = "...";
			// 
			// btnExport
			// 
			this.btnExport.ForeColor = System.Drawing.Color.Black;
			this.btnExport.Location = new System.Drawing.Point(300, 12);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(91, 23);
			this.btnExport.TabIndex = 12;
			this.btnExport.Text = "Export Page";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// EmployeeManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 599);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.lblFeedback);
			this.Controls.Add(this.gbFilter);
			this.Controls.Add(this.btnAddEmployee);
			this.Controls.Add(this.btnDeleteEmployee);
			this.Controls.Add(this.btnEditEmployee);
			this.Controls.Add(this.lblCurrentPage);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.dgEmployees);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "EmployeeManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employee Management";
			this.Load += new System.EventHandler(this.EmployeeManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
			this.gbFilter.ResumeLayout(false);
			this.gbFilter.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgEmployees;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Button btnPrevious;
    private System.Windows.Forms.Label lblCurrentPage;
    private System.Windows.Forms.TextBox txtFilterName;
    private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblEmailFilter;
        private System.Windows.Forms.TextBox txtFilterEmail;
        private System.Windows.Forms.Label lblNameFilter;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.ComboBox ddlFilterGender;
        private System.Windows.Forms.ComboBox ddlFilterStatus;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.Button btnExport;
    }
}

