
namespace QuanLiChuoiCF
{
    partial class fChangePassword
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
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.lbConfirmNewPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.txbConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbNotify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(12, 33);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password:";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Location = new System.Drawing.Point(12, 72);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(81, 13);
            this.lbNewPassword.TabIndex = 1;
            this.lbNewPassword.Text = "New Password:";
            // 
            // lbConfirmNewPassword
            // 
            this.lbConfirmNewPassword.AutoSize = true;
            this.lbConfirmNewPassword.Location = new System.Drawing.Point(12, 114);
            this.lbConfirmNewPassword.Name = "lbConfirmNewPassword";
            this.lbConfirmNewPassword.Size = new System.Drawing.Size(119, 13);
            this.lbConfirmNewPassword.TabIndex = 2;
            this.lbConfirmNewPassword.Text = "Confirm New Password:";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(139, 30);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(211, 20);
            this.txbPassword.TabIndex = 3;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Location = new System.Drawing.Point(139, 70);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(211, 20);
            this.txbNewPassword.TabIndex = 4;
            this.txbNewPassword.UseSystemPasswordChar = true;
            // 
            // txbConfirmNewPassword
            // 
            this.txbConfirmNewPassword.Location = new System.Drawing.Point(139, 110);
            this.txbConfirmNewPassword.Name = "txbConfirmNewPassword";
            this.txbConfirmNewPassword.Size = new System.Drawing.Size(211, 20);
            this.txbConfirmNewPassword.TabIndex = 5;
            this.txbConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(139, 174);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbNotify
            // 
            this.lbNotify.AutoSize = true;
            this.lbNotify.Location = new System.Drawing.Point(136, 146);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(46, 13);
            this.lbNotify.TabIndex = 7;
            this.lbNotify.Text = "NOTIFY";
            // 
            // fChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 229);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txbConfirmNewPassword);
            this.Controls.Add(this.txbNewPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lbConfirmNewPassword);
            this.Controls.Add(this.lbNewPassword);
            this.Controls.Add(this.lbPassword);
            this.Name = "fChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.Label lbConfirmNewPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.TextBox txbConfirmNewPassword;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbNotify;
    }
}