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
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnEditEmployee = new System.Windows.Forms.Button();
			this.btnDeleteEmployee = new System.Windows.Forms.Button();
			this.btnAddEmployee = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
			this.SuspendLayout();
			// 
			// dgEmployees
			// 
			this.dgEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgEmployees.Location = new System.Drawing.Point(13, 40);
			this.dgEmployees.MultiSelect = false;
			this.dgEmployees.Name = "dgEmployees";
			this.dgEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgEmployees.Size = new System.Drawing.Size(853, 521);
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
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Location = new System.Drawing.Point(608, 14);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(192, 20);
			this.txtSearch.TabIndex = 5;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.Location = new System.Drawing.Point(806, 12);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(60, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Search...";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnEditEmployee
			// 
			this.btnEditEmployee.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.btnEditEmployee.Location = new System.Drawing.Point(109, 11);
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
			this.btnDeleteEmployee.Location = new System.Drawing.Point(206, 11);
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
			this.btnAddEmployee.Location = new System.Drawing.Point(12, 11);
			this.btnAddEmployee.Name = "btnAddEmployee";
			this.btnAddEmployee.Size = new System.Drawing.Size(91, 23);
			this.btnAddEmployee.TabIndex = 9;
			this.btnAddEmployee.Text = "Add Employee";
			this.btnAddEmployee.UseVisualStyleBackColor = true;
			this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
			// 
			// EmployeeManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 599);
			this.Controls.Add(this.btnAddEmployee);
			this.Controls.Add(this.btnDeleteEmployee);
			this.Controls.Add(this.btnEditEmployee);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.lblCurrentPage);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.dgEmployees);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Name = "EmployeeManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employee Management";
			this.Load += new System.EventHandler(this.EmployeeManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgEmployees;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Button btnPrevious;
    private System.Windows.Forms.Label lblCurrentPage;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
    }
}

