namespace Aplicacion_de_informe_de_ventas
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
            groupBox1 = new GroupBox();
            btnSubmit = new Button();
            txtItem = new TextBox();
            txtMonday = new TextBox();
            txtTuesday = new TextBox();
            txtWednesday = new TextBox();
            txtThursday = new TextBox();
            txtFriday = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listView1 = new ListView();
            label7 = new Label();
            label8 = new Label();
            txtGrossSales = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(txtItem);
            groupBox1.Controls.Add(txtMonday);
            groupBox1.Controls.Add(txtTuesday);
            groupBox1.Controls.Add(txtWednesday);
            groupBox1.Controls.Add(txtThursday);
            groupBox1.Controls.Add(txtFriday);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 438);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Item";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 378);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(210, 29);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit Item:";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(60, 37);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(200, 27);
            txtItem.TabIndex = 1;
            // 
            // txtMonday
            // 
            txtMonday.Location = new Point(97, 115);
            txtMonday.Name = "txtMonday";
            txtMonday.Size = new Size(125, 27);
            txtMonday.TabIndex = 2;
            // 
            // txtTuesday
            // 
            txtTuesday.Location = new Point(97, 158);
            txtTuesday.Name = "txtTuesday";
            txtTuesday.Size = new Size(125, 27);
            txtTuesday.TabIndex = 3;
            // 
            // txtWednesday
            // 
            txtWednesday.Location = new Point(97, 206);
            txtWednesday.Name = "txtWednesday";
            txtWednesday.Size = new Size(125, 27);
            txtWednesday.TabIndex = 4;
            // 
            // txtThursday
            // 
            txtThursday.Location = new Point(97, 252);
            txtThursday.Name = "txtThursday";
            txtThursday.Size = new Size(125, 27);
            txtThursday.TabIndex = 5;
            // 
            // txtFriday
            // 
            txtFriday.Location = new Point(97, 297);
            txtFriday.Name = "txtFriday";
            txtFriday.Size = new Size(125, 27);
            txtFriday.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 297);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 5;
            label6.Text = "Friday:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 252);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 4;
            label5.Text = "Thursday:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 209);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "Wednesday:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 158);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Tuesday:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Monday:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // listView1
            // 
            listView1.Location = new Point(312, 55);
            listView1.Name = "listView1";
            listView1.Size = new Size(550, 303);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(312, 18);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 9;
            label7.Text = "Itemized sales:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(639, 400);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 10;
            label8.Text = "Gross sales:";
            // 
            // txtGrossSales
            // 
            txtGrossSales.Location = new Point(737, 400);
            txtGrossSales.Name = "txtGrossSales";
            txtGrossSales.ReadOnly = true;
            txtGrossSales.Size = new Size(125, 27);
            txtGrossSales.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 457);
            Controls.Add(txtGrossSales);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sales Report";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSubmit;
        private TextBox txtItem;
        private TextBox txtMonday;
        private TextBox txtTuesday;
        private TextBox txtWednesday;
        private TextBox txtThursday;
        private TextBox txtFriday;
        private ListView listView1;
        private Label label7;
        private Label label8;
        private TextBox txtGrossSales;
    }
}