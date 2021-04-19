
namespace QuanLiChuoiCF
{
    partial class fNewAccount
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.cbbID = new System.Windows.Forms.ComboBox();
            this.lbNotify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(157, 237);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 57);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOkClick);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(61, 23);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(61, 52);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(63, 13);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "User Name:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(61, 89);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(37, 13);
            this.lbType.TabIndex = 3;
            this.lbType.Text = "Type: ";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(61, 122);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password:";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(157, 50);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(236, 20);
            this.txbUserName.TabIndex = 1;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(157, 120);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(236, 20);
            this.txbPassword.TabIndex = 3;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Location = new System.Drawing.Point(61, 157);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.lbConfirmPassword.TabIndex = 9;
            this.lbConfirmPassword.Text = "Confirm Password:";
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.Location = new System.Drawing.Point(157, 156);
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.Size = new System.Drawing.Size(236, 20);
            this.txbConfirmPassword.TabIndex = 4;
            this.txbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(157, 85);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(121, 21);
            this.cbbType.TabIndex = 2;
            // 
            // cbbID
            // 
            this.cbbID.FormattingEnabled = true;
            this.cbbID.Location = new System.Drawing.Point(157, 20);
            this.cbbID.Name = "cbbID";
            this.cbbID.Size = new System.Drawing.Size(121, 21);
            this.cbbID.TabIndex = 10;
            // 
            // lbNotify
            // 
            this.lbNotify.AutoSize = true;
            this.lbNotify.Location = new System.Drawing.Point(154, 194);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(35, 13);
            this.lbNotify.TabIndex = 11;
            this.lbNotify.Text = "label1";
            // 
            // fNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 498);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.cbbID);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.txbConfirmPassword);
            this.Controls.Add(this.lbConfirmPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnOK);
            this.Name = "fNewAccount";
            this.Text = "fNewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.TextBox txbConfirmPassword;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.ComboBox cbbID;
        private System.Windows.Forms.Label lbNotify;
    }
}