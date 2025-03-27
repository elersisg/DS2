namespace Programmer_s_Shopping_Cart
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
            groupBox1 = new GroupBox();
            chkCsharpForProgrammers = new CheckBox();
            chkCsharpSchool = new CheckBox();
            chkCsharpHowToProgram = new CheckBox();
            label2 = new Label();
            txtComments = new TextBox();
            groupBox2 = new GroupBox();
            rbtnFullPayment = new RadioButton();
            rbtnInstantPayment = new RadioButton();
            btnCalculate = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 30);
            label1.Name = "label1";
            label1.Size = new Size(530, 50);
            label1.TabIndex = 0;
            label1.Text = "Programmer's Shopping Cart";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkCsharpForProgrammers);
            groupBox1.Controls.Add(chkCsharpSchool);
            groupBox1.Controls.Add(chkCsharpHowToProgram);
            groupBox1.Location = new Point(37, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 182);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Available Books ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // chkCsharpForProgrammers
            // 
            chkCsharpForProgrammers.AutoSize = true;
            chkCsharpForProgrammers.Location = new Point(6, 79);
            chkCsharpForProgrammers.Name = "chkCsharpForProgrammers";
            chkCsharpForProgrammers.Size = new Size(209, 24);
            chkCsharpForProgrammers.TabIndex = 2;
            chkCsharpForProgrammers.Text = "C # For Programmers ($30)";
            chkCsharpForProgrammers.UseVisualStyleBackColor = true;
            chkCsharpForProgrammers.CheckedChanged += chkCsharpForProgrammers_CheckedChanged;
            // 
            // chkCsharpSchool
            // 
            chkCsharpSchool.AutoSize = true;
            chkCsharpSchool.Location = new Point(6, 126);
            chkCsharpSchool.Name = "chkCsharpSchool";
            chkCsharpSchool.Size = new Size(136, 24);
            chkCsharpSchool.TabIndex = 3;
            chkCsharpSchool.Text = "C# School ($20)";
            chkCsharpSchool.UseVisualStyleBackColor = true;
            chkCsharpSchool.CheckedChanged += chkCsharpSchool_CheckedChanged;
            // 
            // chkCsharpHowToProgram
            // 
            chkCsharpHowToProgram.AutoSize = true;
            chkCsharpHowToProgram.Location = new Point(6, 36);
            chkCsharpHowToProgram.Name = "chkCsharpHowToProgram";
            chkCsharpHowToProgram.Size = new Size(203, 24);
            chkCsharpHowToProgram.TabIndex = 0;
            chkCsharpHowToProgram.Text = "C# How To Program ($50)";
            chkCsharpHowToProgram.UseVisualStyleBackColor = true;
            chkCsharpHowToProgram.CheckedChanged += chkCsharpHowToProgram_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 319);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 4;
            label2.Text = "Your comments:";
            // 
            // txtComments
            // 
            txtComments.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtComments.Location = new Point(12, 353);
            txtComments.Multiline = true;
            txtComments.Name = "txtComments";
            txtComments.Size = new Size(420, 205);
            txtComments.TabIndex = 5;
            txtComments.Text = "Write your comments";
            txtComments.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtnFullPayment);
            groupBox2.Controls.Add(rbtnInstantPayment);
            groupBox2.Location = new Point(422, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 221);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Payment mode";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // rbtnFullPayment
            // 
            rbtnFullPayment.AutoSize = true;
            rbtnFullPayment.Location = new Point(6, 88);
            rbtnFullPayment.Name = "rbtnFullPayment";
            rbtnFullPayment.Size = new Size(113, 24);
            rbtnFullPayment.TabIndex = 1;
            rbtnFullPayment.TabStop = true;
            rbtnFullPayment.Text = "Full Payment";
            rbtnFullPayment.UseVisualStyleBackColor = true;
            rbtnFullPayment.CheckedChanged += rbtnFullPayment_CheckedChanged;
            // 
            // rbtnInstantPayment
            // 
            rbtnInstantPayment.AutoSize = true;
            rbtnInstantPayment.Location = new Point(6, 45);
            rbtnInstantPayment.Name = "rbtnInstantPayment";
            rbtnInstantPayment.Size = new Size(134, 24);
            rbtnInstantPayment.TabIndex = 0;
            rbtnInstantPayment.TabStop = true;
            rbtnInstantPayment.Text = "Instant Payment";
            rbtnInstantPayment.UseVisualStyleBackColor = true;
            rbtnInstantPayment.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(506, 366);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(265, 67);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Purchase";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnPurchase_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(506, 450);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(265, 68);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 570);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox2);
            Controls.Add(txtComments);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private CheckBox chkCsharpForProgrammers;
        private CheckBox chkCsharpSchool;
        private CheckBox chkCsharpHowToProgram;
        private Label label2;
        private TextBox txtComments;
        private GroupBox groupBox2;
        private RadioButton rbtnFullPayment;
        private RadioButton rbtnInstantPayment;
        private Button btnCalculate;
        private Button btnExit;
    }
}