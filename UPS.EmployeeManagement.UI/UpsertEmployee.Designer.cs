namespace UPS.EmployeeManagement.UI
{
    partial class UpsertEmployee
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
			this.lblName = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnUpsert = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.ddlFilterGender = new System.Windows.Forms.ComboBox();
			this.ddlFilterStatus = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(19, 12);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(22, 40);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(35, 13);
			this.lblEmail.TabIndex = 1;
			this.lblEmail.Text = "Email:";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Location = new System.Drawing.Point(12, 79);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(45, 13);
			this.lblGender.TabIndex = 2;
			this.lblGender.Text = "Gender:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(64, 9);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(278, 20);
			this.txtName.TabIndex = 1;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(64, 37);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(278, 20);
			this.txtEmail.TabIndex = 2;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(12, 110);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(40, 13);
			this.lblStatus.TabIndex = 6;
			this.lblStatus.Text = "Status:";
			// 
			// btnUpsert
			// 
			this.btnUpsert.Location = new System.Drawing.Point(124, 141);
			this.btnUpsert.Name = "btnUpsert";
			this.btnUpsert.Size = new System.Drawing.Size(75, 23);
			this.btnUpsert.TabIndex = 8;
			this.btnUpsert.Text = "Upsert";
			this.btnUpsert.UseVisualStyleBackColor = true;
			this.btnUpsert.Click += new System.EventHandler(this.btnUpsert_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(205, 141);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// ddlFilterGender
			// 
			this.ddlFilterGender.FormattingEnabled = true;
			this.ddlFilterGender.Items.AddRange(new object[] {
            "Select...",
            "Male",
            "Female"});
			this.ddlFilterGender.Location = new System.Drawing.Point(63, 76);
			this.ddlFilterGender.Name = "ddlFilterGender";
			this.ddlFilterGender.Size = new System.Drawing.Size(80, 21);
			this.ddlFilterGender.TabIndex = 3;
			// 
			// ddlFilterStatus
			// 
			this.ddlFilterStatus.FormattingEnabled = true;
			this.ddlFilterStatus.Items.AddRange(new object[] {
            "Select...",
            "Active",
            "Inactive"});
			this.ddlFilterStatus.Location = new System.Drawing.Point(63, 107);
			this.ddlFilterStatus.Name = "ddlFilterStatus";
			this.ddlFilterStatus.Size = new System.Drawing.Size(80, 21);
			this.ddlFilterStatus.TabIndex = 4;
			// 
			// UpsertEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 176);
			this.Controls.Add(this.ddlFilterStatus);
			this.Controls.Add(this.ddlFilterGender);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpsert);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UpsertEmployee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Upsert Employee";
			this.Load += new System.EventHandler(this.UpsertEmployee_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnUpsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox ddlFilterGender;
        private System.Windows.Forms.ComboBox ddlFilterStatus;
    }
}
