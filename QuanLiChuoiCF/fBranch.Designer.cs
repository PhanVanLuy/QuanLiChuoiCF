
namespace QuanLiChuoiCF
{
    partial class fBranch
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMNEms = new System.Windows.Forms.Button();
            this.btnMNInCome = new System.Windows.Forms.Button();
            this.btnQLMateríal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(509, 347);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnMNEms
            // 
            this.btnMNEms.Location = new System.Drawing.Point(566, 34);
            this.btnMNEms.Name = "btnMNEms";
            this.btnMNEms.Size = new System.Drawing.Size(140, 23);
            this.btnMNEms.TabIndex = 1;
            this.btnMNEms.Text = "Quản Lý Nhân Viên";
            this.btnMNEms.UseVisualStyleBackColor = true;
            this.btnMNEms.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMNInCome
            // 
            this.btnMNInCome.Location = new System.Drawing.Point(566, 108);
            this.btnMNInCome.Name = "btnMNInCome";
            this.btnMNInCome.Size = new System.Drawing.Size(140, 23);
            this.btnMNInCome.TabIndex = 1;
            this.btnMNInCome.Text = "Quản lý thu Nhập";
            this.btnMNInCome.UseVisualStyleBackColor = true;
            this.btnMNInCome.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnQLMateríal
            // 
            this.btnQLMateríal.Location = new System.Drawing.Point(566, 178);
            this.btnQLMateríal.Name = "btnQLMateríal";
            this.btnQLMateríal.Size = new System.Drawing.Size(140, 23);
            this.btnQLMateríal.TabIndex = 1;
            this.btnQLMateríal.Text = "Quản lý nguyên liệu";
            this.btnQLMateríal.UseVisualStyleBackColor = true;
            this.btnQLMateríal.Click += new System.EventHandler(this.button4_Click);
            // 
            // fBranch
            // 
            this.ClientSize = new System.Drawing.Size(728, 390);
            this.Controls.Add(this.btnQLMateríal);
            this.Controls.Add(this.btnMNInCome);
            this.Controls.Add(this.btnMNEms);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "fBranch";
            this.Text = "Chi nhánh";
            this.Load += new System.EventHandler(this.fBranch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnMNEms;
        private System.Windows.Forms.Button btnMNInCome;
        private System.Windows.Forms.Button btnQLMateríal;
    }
}