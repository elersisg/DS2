namespace Interest_calculator
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
            nudYears = new NumericUpDown();
            label1 = new Label();
            btnCalculate = new Button();
            txtYearlyAccountBalance = new TextBox();
            txtPrincipal = new TextBox();
            txtInterestRate = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudYears).BeginInit();
            SuspendLayout();
            // 
            // nudYears
            // 
            nudYears.Cursor = Cursors.No;
            nudYears.Location = new Point(153, 122);
            nudYears.Name = "nudYears";
            nudYears.Size = new Size(188, 27);
            nudYears.TabIndex = 0;
            nudYears.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(58, 18);
            label1.TabIndex = 1;
            label1.Text = "Principal";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(404, 23);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_TextChanged;
            // 
            // txtYearlyAccountBalance
            // 
            txtYearlyAccountBalance.Location = new Point(25, 197);
            txtYearlyAccountBalance.Multiline = true;
            txtYearlyAccountBalance.Name = "txtYearlyAccountBalance";
            txtYearlyAccountBalance.ReadOnly = true;
            txtYearlyAccountBalance.ScrollBars = ScrollBars.Vertical;
            txtYearlyAccountBalance.Size = new Size(529, 252);
            txtYearlyAccountBalance.TabIndex = 3;
            // 
            // txtPrincipal
            // 
            txtPrincipal.Location = new Point(153, 23);
            txtPrincipal.Name = "txtPrincipal";
            txtPrincipal.Size = new Size(188, 27);
            txtPrincipal.TabIndex = 4;
            txtPrincipal.TextChanged += txtPrincipal_TextChanged;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(152, 69);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(189, 27);
            txtInterestRate.TabIndex = 5;
            txtInterestRate.TextChanged += txtInterestRate_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 72);
            label2.Name = "label2";
            label2.Size = new Size(95, 18);
            label2.TabIndex = 6;
            label2.Text = "Interest Rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 124);
            label3.Name = "label3";
            label3.Size = new Size(46, 18);
            label3.TabIndex = 7;
            label3.Text = "Years";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 174);
            label4.Name = "label4";
            label4.Size = new Size(159, 18);
            label4.TabIndex = 8;
            label4.Text = "Yearly account balance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 503);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtInterestRate);
            Controls.Add(txtPrincipal);
            Controls.Add(txtYearlyAccountBalance);
            Controls.Add(btnCalculate);
            Controls.Add(label1);
            Controls.Add(nudYears);
            Name = "Form1";
            Text = "Interest calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudYears).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudYears;
        private Label label1;
        private Button btnCalculate;
        private TextBox txtYearlyAccountBalance;
        private TextBox txtPrincipal;
        private TextBox txtInterestRate;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}