
namespace QuanLiChuoiCF
{
    partial class AddSupplier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.btn_AddSupplier = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txb_Address);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txb_Name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 188);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_AddSupplier);
            this.panel2.Location = new System.Drawing.Point(1, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 44);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(100, 65);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(339, 20);
            this.txb_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address:";
            // 
            // txb_Address
            // 
            this.txb_Address.Location = new System.Drawing.Point(100, 116);
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(339, 20);
            this.txb_Address.TabIndex = 1;
            // 
            // btn_AddSupplier
            // 
            this.btn_AddSupplier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddSupplier.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_AddSupplier.Location = new System.Drawing.Point(154, 3);
            this.btn_AddSupplier.Name = "btn_AddSupplier";
            this.btn_AddSupplier.Size = new System.Drawing.Size(192, 38);
            this.btn_AddSupplier.TabIndex = 0;
            this.btn_AddSupplier.Text = "Add";
            this.btn_AddSupplier.UseVisualStyleBackColor = false;
            this.btn_AddSupplier.Click += new System.EventHandler(this.btn_AddSupplier_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(159, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "FILL INFORMATION FOR SUPPLIER";
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 289);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddSupplier";
            this.Text = "Add Supplier";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddSupplier;
        private System.Windows.Forms.Label label3;
    }
}