namespace Fuzzy_Dice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAddress3 = new TextBox();
            txtName = new TextBox();
            txtAddress2 = new TextBox();
            txtOrderNumber = new TextBox();
            txtAddress1 = new TextBox();
            label5 = new Label();
            chkWhiteBlack = new CheckBox();
            chkRedBlack = new CheckBox();
            chkBlueBlack = new CheckBox();
            label6 = new Label();
            txtQuantityWhiteBlack = new TextBox();
            txtQuantityRedBlack = new TextBox();
            txtQuantityBlueBlack = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            btnCalculate = new Button();
            txtTotalWhiteBlack = new TextBox();
            txtTotalRedBlack = new TextBox();
            txtTotalBlueBlack = new TextBox();
            txtSubtotal = new TextBox();
            txtTax = new TextBox();
            txtShipping = new TextBox();
            txtDiscount = new TextBox();
            txtTotal = new TextBox();
            btnOrderNumber = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(229, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 46);
            label1.TabIndex = 0;
            label1.Text = "Fuzzy Dice ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 111);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Order Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 177);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 229);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Address:";
            // 
            // txtAddress3
            // 
            txtAddress3.Location = new Point(135, 288);
            txtAddress3.Name = "txtAddress3";
            txtAddress3.PlaceholderText = "Address Line 3";
            txtAddress3.Size = new Size(208, 27);
            txtAddress3.TabIndex = 4;
            txtAddress3.TextChanged += txtAddress3_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 177);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 27);
            txtName.TabIndex = 5;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAddress2
            // 
            txtAddress2.Location = new Point(135, 255);
            txtAddress2.Name = "txtAddress2";
            txtAddress2.PlaceholderText = "Address Line 2";
            txtAddress2.Size = new Size(208, 27);
            txtAddress2.TabIndex = 6;
            txtAddress2.TextChanged += txtAddress2_TextChanged;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(158, 108);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(74, 27);
            txtOrderNumber.TabIndex = 7;
            txtOrderNumber.TextChanged += txtOrderNumber_TextChanged;
            // 
            // txtAddress1
            // 
            txtAddress1.Location = new Point(135, 222);
            txtAddress1.Name = "txtAddress1";
            txtAddress1.PlaceholderText = "Address Line 1";
            txtAddress1.Size = new Size(208, 27);
            txtAddress1.TabIndex = 8;
            txtAddress1.TextChanged += txtAddress1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 351);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 9;
            label5.Text = "Type:";
            // 
            // chkWhiteBlack
            // 
            chkWhiteBlack.AutoSize = true;
            chkWhiteBlack.Location = new Point(33, 392);
            chkWhiteBlack.Name = "chkWhiteBlack";
            chkWhiteBlack.Size = new Size(115, 24);
            chkWhiteBlack.TabIndex = 10;
            chkWhiteBlack.Text = "White/Black ";
            chkWhiteBlack.UseVisualStyleBackColor = true;
            chkWhiteBlack.CheckedChanged += chkWhiteBlack_CheckedChanged;
            // 
            // chkRedBlack
            // 
            chkRedBlack.AutoSize = true;
            chkRedBlack.Location = new Point(33, 422);
            chkRedBlack.Name = "chkRedBlack";
            chkRedBlack.Size = new Size(102, 24);
            chkRedBlack.TabIndex = 11;
            chkRedBlack.Text = "Red/Black ";
            chkRedBlack.UseVisualStyleBackColor = true;
            chkRedBlack.CheckedChanged += chkRedBlack_CheckedChanged;
            // 
            // chkBlueBlack
            // 
            chkBlueBlack.AutoSize = true;
            chkBlueBlack.Location = new Point(33, 452);
            chkBlueBlack.Name = "chkBlueBlack";
            chkBlueBlack.Size = new Size(101, 24);
            chkBlueBlack.TabIndex = 12;
            chkBlueBlack.Text = "Blue/Black";
            chkBlueBlack.UseVisualStyleBackColor = true;
            chkBlueBlack.CheckedChanged += chkBlueBlack_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 351);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 13;
            label6.Text = "Quantity:";
            // 
            // txtQuantityWhiteBlack
            // 
            txtQuantityWhiteBlack.Location = new Point(177, 383);
            txtQuantityWhiteBlack.Name = "txtQuantityWhiteBlack";
            txtQuantityWhiteBlack.Size = new Size(125, 27);
            txtQuantityWhiteBlack.TabIndex = 14;
            txtQuantityWhiteBlack.TextChanged += txtQuantityWhiteBlack_TextChanged;
            // 
            // txtQuantityRedBlack
            // 
            txtQuantityRedBlack.Location = new Point(177, 416);
            txtQuantityRedBlack.Name = "txtQuantityRedBlack";
            txtQuantityRedBlack.Size = new Size(125, 27);
            txtQuantityRedBlack.TabIndex = 15;
            txtQuantityRedBlack.TextChanged += txtQuantityRedBlack_TextChanged;
            // 
            // txtQuantityBlueBlack
            // 
            txtQuantityBlueBlack.Location = new Point(177, 449);
            txtQuantityBlueBlack.Name = "txtQuantityBlueBlack";
            txtQuantityBlueBlack.Size = new Size(125, 27);
            txtQuantityBlueBlack.TabIndex = 16;
            txtQuantityBlueBlack.TextChanged += txtQuantityBlueBlack_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(329, 351);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 17;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(329, 383);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 18;
            label8.Text = "$6.25";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(329, 419);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 19;
            label9.Text = "$5.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(329, 456);
            label10.Name = "label10";
            label10.Size = new Size(44, 20);
            label10.TabIndex = 20;
            label10.Text = "$7.50";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(329, 490);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 21;
            label11.Text = "Subtotal:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(329, 524);
            label12.Name = "label12";
            label12.Size = new Size(33, 20);
            label12.TabIndex = 22;
            label12.Text = "Tax:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(329, 559);
            label13.Name = "label13";
            label13.Size = new Size(71, 20);
            label13.TabIndex = 23;
            label13.Text = "Shipping:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(329, 593);
            label14.Name = "label14";
            label14.Size = new Size(70, 20);
            label14.TabIndex = 24;
            label14.Text = "Discount:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(442, 351);
            label15.Name = "label15";
            label15.Size = new Size(48, 20);
            label15.TabIndex = 25;
            label15.Text = "Totals";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(329, 632);
            label16.Name = "label16";
            label16.Size = new Size(45, 20);
            label16.TabIndex = 26;
            label16.Text = "Total:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(442, 674);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(131, 29);
            btnCalculate.TabIndex = 27;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtTotalWhiteBlack
            // 
            txtTotalWhiteBlack.Location = new Point(442, 380);
            txtTotalWhiteBlack.Name = "txtTotalWhiteBlack";
            txtTotalWhiteBlack.ReadOnly = true;
            txtTotalWhiteBlack.Size = new Size(125, 27);
            txtTotalWhiteBlack.TabIndex = 28;
            // 
            // txtTotalRedBlack
            // 
            txtTotalRedBlack.Location = new Point(442, 416);
            txtTotalRedBlack.Name = "txtTotalRedBlack";
            txtTotalRedBlack.ReadOnly = true;
            txtTotalRedBlack.Size = new Size(125, 27);
            txtTotalRedBlack.TabIndex = 29;
            // 
            // txtTotalBlueBlack
            // 
            txtTotalBlueBlack.Location = new Point(442, 458);
            txtTotalBlueBlack.Name = "txtTotalBlueBlack";
            txtTotalBlueBlack.ReadOnly = true;
            txtTotalBlueBlack.Size = new Size(125, 27);
            txtTotalBlueBlack.TabIndex = 30;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(442, 491);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(125, 27);
            txtSubtotal.TabIndex = 31;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(442, 524);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(125, 27);
            txtTax.TabIndex = 32;
            txtTax.TextChanged += txtTax_TextChanged;
            // 
            // txtShipping
            // 
            txtShipping.Location = new Point(442, 560);
            txtShipping.Name = "txtShipping";
            txtShipping.ReadOnly = true;
            txtShipping.Size = new Size(125, 27);
            txtShipping.TabIndex = 33;
            txtShipping.TextChanged += txtShipping_TextChanged;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(442, 593);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(125, 27);
            txtDiscount.TabIndex = 34;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(442, 632);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 35;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // btnOrderNumber
            // 
            btnOrderNumber.Location = new Point(268, 108);
            btnOrderNumber.Name = "btnOrderNumber";
            btnOrderNumber.Size = new Size(94, 29);
            btnOrderNumber.TabIndex = 36;
            btnOrderNumber.Text = "Generate ";
            btnOrderNumber.UseVisualStyleBackColor = true;
            btnOrderNumber.Click += btnOrderNumber_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(607, 715);
            Controls.Add(btnOrderNumber);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscount);
            Controls.Add(txtShipping);
            Controls.Add(txtTax);
            Controls.Add(txtSubtotal);
            Controls.Add(txtTotalBlueBlack);
            Controls.Add(txtTotalRedBlack);
            Controls.Add(txtTotalWhiteBlack);
            Controls.Add(btnCalculate);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtQuantityBlueBlack);
            Controls.Add(txtQuantityRedBlack);
            Controls.Add(txtQuantityWhiteBlack);
            Controls.Add(label6);
            Controls.Add(chkBlueBlack);
            Controls.Add(chkRedBlack);
            Controls.Add(chkWhiteBlack);
            Controls.Add(label5);
            Controls.Add(txtAddress1);
            Controls.Add(txtOrderNumber);
            Controls.Add(txtAddress2);
            Controls.Add(txtName);
            Controls.Add(txtAddress3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Modified Fuzzy Dice Order Form  ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAddress3;
        private TextBox txtName;
        private TextBox txtAddress2;
        private TextBox txtOrderNumber;
        private TextBox txtAddress1;
        private Label label5;
        private CheckBox chkWhiteBlack;
        private CheckBox chkRedBlack;
        private CheckBox chkBlueBlack;
        private Label label6;
        private TextBox txtQuantityWhiteBlack;
        private TextBox txtQuantityRedBlack;
        private TextBox txtQuantityBlueBlack;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button btnCalculate;
        private TextBox txtTotalWhiteBlack;
        private TextBox txtTotalRedBlack;
        private TextBox txtTotalBlueBlack;
        private TextBox txtSubtotal;
        private TextBox txtTax;
        private TextBox txtShipping;
        private TextBox txtDiscount;
        private TextBox txtTotal;
        private Button btnOrderNumber;
    }
}