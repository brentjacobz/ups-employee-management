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
			this.dgEmployees.Name = "dgEmployees";
			this.dgEmployees.Size = new System.Drawing.Size(775, 372);
			this.dgEmployees.TabIndex = 0;
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Enabled = false;
			this.btnNext.Location = new System.Drawing.Point(728, 418);
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
			this.btnPrevious.Location = new System.Drawing.Point(578, 418);
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
			this.lblCurrentPage.Location = new System.Drawing.Point(645, 423);
			this.lblCurrentPage.Name = "lblCurrentPage";
			this.lblCurrentPage.Size = new System.Drawing.Size(77, 13);
			this.lblCurrentPage.TabIndex = 4;
			this.lblCurrentPage.Text = "Page: 1 of 100";
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Location = new System.Drawing.Point(530, 14);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(192, 20);
			this.txtSearch.TabIndex = 5;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.Location = new System.Drawing.Point(728, 12);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(60, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Search...";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// EmployeeManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.lblCurrentPage);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.dgEmployees);
			this.Name = "EmployeeManagement";
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
  }
}

