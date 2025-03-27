namespace Loan_Calculator
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
            label5 = new Label();
            label6 = new Label();
            btnCalcular = new Button();
            btnExit = new Button();
            txtMonthlyPayments = new TextBox();
            txtDuration = new TextBox();
            txtInterestRate = new TextBox();
            txtLoanAmount = new TextBox();
            chkEarlyPayments = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 31);
            label1.Name = "label1";
            label1.Size = new Size(321, 45);
            label1.TabIndex = 0;
            label1.Text = "Loan Calculator ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 149);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Loan Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 199);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 2;
            label3.Text = "Interest Rate (annual)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 245);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 3;
            label4.Text = "Duration (months)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 292);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 4;
            label5.Text = "Early Payments";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 346);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 5;
            label6.Text = "Monthly Payment";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(51, 406);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(146, 58);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calculate";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(277, 406);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(142, 58);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtMonthlyPayments
            // 
            txtMonthlyPayments.Location = new Point(301, 343);
            txtMonthlyPayments.Name = "txtMonthlyPayments";
            txtMonthlyPayments.ReadOnly = true;
            txtMonthlyPayments.Size = new Size(125, 27);
            txtMonthlyPayments.TabIndex = 8;
            txtMonthlyPayments.TextChanged += txtMonthlyPayments_TextChanged;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(301, 242);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(125, 27);
            txtDuration.TabIndex = 9;
            txtDuration.TextChanged += txtDuration_TextChanged;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(301, 192);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(125, 27);
            txtInterestRate.TabIndex = 10;
            txtInterestRate.TextChanged += txtInterestRate_TextChanged;
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Location = new Point(301, 133);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(125, 27);
            txtLoanAmount.TabIndex = 11;
            txtLoanAmount.TextChanged += txtLoanAmount_TextChanged;
            // 
            // chkEarlyPayments
            // 
            chkEarlyPayments.AutoSize = true;
            chkEarlyPayments.Location = new Point(401, 305);
            chkEarlyPayments.Name = "chkEarlyPayments";
            chkEarlyPayments.Size = new Size(18, 17);
            chkEarlyPayments.TabIndex = 12;
            chkEarlyPayments.UseVisualStyleBackColor = true;
            chkEarlyPayments.CheckedChanged += chkEarlyPayments_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 502);
            Controls.Add(chkEarlyPayments);
            Controls.Add(txtLoanAmount);
            Controls.Add(txtInterestRate);
            Controls.Add(txtDuration);
            Controls.Add(txtMonthlyPayments);
            Controls.Add(btnExit);
            Controls.Add(btnCalcular);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtMonthlyPayments_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCalcular;
        private Button btnExit;
        private TextBox txtMonthlyPayments;
        private TextBox txtDuration;
        private TextBox txtInterestRate;
        private TextBox txtLoanAmount;
        private CheckBox chkEarlyPayments;
    }
}