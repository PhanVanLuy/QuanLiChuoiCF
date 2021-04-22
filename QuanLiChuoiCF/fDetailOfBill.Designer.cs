
namespace QuanLiChuoiCF
{
    partial class fDetailOfBill
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
            System.Windows.Forms.ColumnHeader clHDrinkName;
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvDetailOfBill = new System.Windows.Forms.ListView();
            this.clHAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHTotalAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDrinkName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbTotalAmount = new System.Windows.Forms.TextBox();
            clHDrinkName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // clHDrinkName
            // 
            clHDrinkName.Text = "Drink Name";
            clHDrinkName.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvDetailOfBill);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 510);
            this.panel1.TabIndex = 0;
            // 
            // lsvDetailOfBill
            // 
            this.lsvDetailOfBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            clHDrinkName,
            this.clHAmount,
            this.clHPrice,
            this.clHTotalAmount});
            this.lsvDetailOfBill.HideSelection = false;
            this.lsvDetailOfBill.Location = new System.Drawing.Point(0, 3);
            this.lsvDetailOfBill.Name = "lsvDetailOfBill";
            this.lsvDetailOfBill.Size = new System.Drawing.Size(480, 500);
            this.lsvDetailOfBill.TabIndex = 3;
            this.lsvDetailOfBill.TabStop = false;
            this.lsvDetailOfBill.UseCompatibleStateImageBehavior = false;
            this.lsvDetailOfBill.View = System.Windows.Forms.View.Details;
            // 
            // clHAmount
            // 
            this.clHAmount.Text = "Amount";
            this.clHAmount.Width = 120;
            // 
            // clHPrice
            // 
            this.clHPrice.Text = "Price";
            this.clHPrice.Width = 120;
            // 
            // clHTotalAmount
            // 
            this.clHTotalAmount.Text = "TotalAmount";
            this.clHTotalAmount.Width = 120;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbTotalAmount);
            this.panel2.Controls.Add(this.txbPrice);
            this.panel2.Controls.Add(this.lbTotalAmount);
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbDrinkName);
            this.panel2.Location = new System.Drawing.Point(552, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 155);
            this.panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(98, 51);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // lbDrinkName
            // 
            this.lbDrinkName.AutoSize = true;
            this.lbDrinkName.Location = new System.Drawing.Point(26, 19);
            this.lbDrinkName.Name = "lbDrinkName";
            this.lbDrinkName.Size = new System.Drawing.Size(66, 13);
            this.lbDrinkName.TabIndex = 0;
            this.lbDrinkName.Text = "Drink Name:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(552, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 46);
            this.panel3.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(179, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(98, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(26, 92);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "Price";
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.Location = new System.Drawing.Point(26, 125);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(73, 13);
            this.lbTotalAmount.TabIndex = 8;
            this.lbTotalAmount.Text = "Total Amount:";
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(98, 85);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(274, 20);
            this.txbPrice.TabIndex = 9;
            // 
            // txbTotalAmount
            // 
            this.txbTotalAmount.Location = new System.Drawing.Point(98, 118);
            this.txbTotalAmount.Name = "txbTotalAmount";
            this.txbTotalAmount.Size = new System.Drawing.Size(274, 20);
            this.txbTotalAmount.TabIndex = 10;
            // 
            // fDetailOfBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 518);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fDetailOfBill";
            this.Text = "fDetailOfBill";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDrinkName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lsvDetailOfBill;
        private System.Windows.Forms.ColumnHeader clHAmount;
        private System.Windows.Forms.ColumnHeader clHPrice;
        private System.Windows.Forms.ColumnHeader clHTotalAmount;
        private System.Windows.Forms.TextBox txbTotalAmount;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Label lbPrice;
    }
}