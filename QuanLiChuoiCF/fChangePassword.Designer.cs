
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
            this.txbPassword = new System.Windows.Forms.Label();
            this.txbNewPassword = new System.Windows.Forms.Label();
            this.txbConfirmNewPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbPassword
            // 
            this.txbPassword.AutoSize = true;
            this.txbPassword.Location = new System.Drawing.Point(12, 33);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(56, 13);
            this.txbPassword.TabIndex = 0;
            this.txbPassword.Text = "Password:";
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.AutoSize = true;
            this.txbNewPassword.Location = new System.Drawing.Point(12, 72);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(81, 13);
            this.txbNewPassword.TabIndex = 1;
            this.txbNewPassword.Text = "New Password:";
            // 
            // txbConfirmNewPassword
            // 
            this.txbConfirmNewPassword.AutoSize = true;
            this.txbConfirmNewPassword.Location = new System.Drawing.Point(12, 114);
            this.txbConfirmNewPassword.Name = "txbConfirmNewPassword";
            this.txbConfirmNewPassword.Size = new System.Drawing.Size(119, 13);
            this.txbConfirmNewPassword.TabIndex = 2;
            this.txbConfirmNewPassword.Text = "Confirm New Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(192, 148);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // fChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 194);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txbConfirmNewPassword);
            this.Controls.Add(this.txbNewPassword);
            this.Controls.Add(this.txbPassword);
            this.Name = "fChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txbPassword;
        private System.Windows.Forms.Label txbNewPassword;
        private System.Windows.Forms.Label txbConfirmNewPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnOK;
    }
}