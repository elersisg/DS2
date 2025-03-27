namespace Shippinghub
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
            txtarrivedat = new TextBox();
            groupBox1 = new GroupBox();
            txtzip = new TextBox();
            label6 = new Label();
            cmbstate = new ComboBox();
            label5 = new Label();
            txtpackageID = new TextBox();
            txtaddress = new TextBox();
            txtcity = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            lstPackages = new ListBox();
            cmbpackagesbystate = new ComboBox();
            btnback = new Button();
            btnscannew = new Button();
            btnadd = new Button();
            btnremove = new Button();
            btnEdit = new Button();
            btnnext = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 22);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Arrived At:";
            // 
            // txtarrivedat
            // 
            txtarrivedat.Location = new Point(134, 19);
            txtarrivedat.Name = "txtarrivedat";
            txtarrivedat.ReadOnly = true;
            txtarrivedat.Size = new Size(251, 27);
            txtarrivedat.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtzip);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbstate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtpackageID);
            groupBox1.Controls.Add(txtaddress);
            groupBox1.Controls.Add(txtcity);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(33, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(612, 294);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Package Information ";
            // 
            // txtzip
            // 
            txtzip.Location = new Point(484, 225);
            txtzip.Name = "txtzip";
            txtzip.Size = new Size(110, 27);
            txtzip.TabIndex = 9;
            txtzip.TextChanged += txtzip_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 228);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 8;
            label6.Text = "Zip:";
            // 
            // cmbstate
            // 
            cmbstate.FormattingEnabled = true;
            cmbstate.Location = new Point(294, 225);
            cmbstate.Name = "cmbstate";
            cmbstate.Size = new Size(103, 28);
            cmbstate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 228);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "State:";
            // 
            // txtpackageID
            // 
            txtpackageID.Location = new Point(101, 75);
            txtpackageID.Name = "txtpackageID";
            txtpackageID.ReadOnly = true;
            txtpackageID.Size = new Size(289, 27);
            txtpackageID.TabIndex = 5;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(101, 157);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(289, 27);
            txtaddress.TabIndex = 4;
            // 
            // txtcity
            // 
            txtcity.Location = new Point(101, 221);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(110, 27);
            txtcity.TabIndex = 3;
            txtcity.TextChanged += txtcity_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 228);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 2;
            label4.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 157);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 1;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 0;
            label2.Text = "Package ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstPackages);
            groupBox2.Controls.Add(cmbpackagesbystate);
            groupBox2.Location = new Point(676, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 314);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Packages by State";
            // 
            // lstPackages
            // 
            lstPackages.FormattingEnabled = true;
            lstPackages.ItemHeight = 20;
            lstPackages.Location = new Point(31, 106);
            lstPackages.Name = "lstPackages";
            lstPackages.Size = new Size(202, 184);
            lstPackages.TabIndex = 11;
            lstPackages.SelectedIndexChanged += lstPackages_SelectedIndexChanged;
            // 
            // cmbpackagesbystate
            // 
            cmbpackagesbystate.FormattingEnabled = true;
            cmbpackagesbystate.Location = new Point(31, 43);
            cmbpackagesbystate.Name = "cmbpackagesbystate";
            cmbpackagesbystate.Size = new Size(202, 28);
            cmbpackagesbystate.TabIndex = 10;
            cmbpackagesbystate.SelectedIndexChanged += cmbpackagesbystate_SelectedIndexChanged;
            // 
            // btnback
            // 
            btnback.Location = new Point(17, 423);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 4;
            btnback.Text = "<BACK";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnscannew
            // 
            btnscannew.Location = new Point(117, 423);
            btnscannew.Name = "btnscannew";
            btnscannew.Size = new Size(94, 29);
            btnscannew.TabIndex = 5;
            btnscannew.Text = "Scan New";
            btnscannew.UseVisualStyleBackColor = true;
            btnscannew.Click += btnscannew_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(217, 423);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 29);
            btnadd.TabIndex = 6;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnremove
            // 
            btnremove.Location = new Point(317, 423);
            btnremove.Name = "btnremove";
            btnremove.Size = new Size(94, 29);
            btnremove.TabIndex = 7;
            btnremove.Text = "Remove";
            btnremove.UseVisualStyleBackColor = true;
            btnremove.Click += btnremove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(417, 423);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(517, 423);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(94, 29);
            btnnext.TabIndex = 9;
            btnnext.Text = "NEXT>";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 487);
            Controls.Add(btnnext);
            Controls.Add(btnEdit);
            Controls.Add(btnremove);
            Controls.Add(btnadd);
            Controls.Add(btnscannew);
            Controls.Add(btnback);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtarrivedat);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtcity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtzip_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private Label label1;
        private TextBox txtarrivedat;
        private GroupBox groupBox1;
        private TextBox txtpackageID;
        private TextBox txtaddress;
        private TextBox txtcity;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtzip;
        private Label label6;
        private ComboBox cmbstate;
        private Label label5;
        private GroupBox groupBox2;
        private Button btnback;
        private Button btnscannew;
        private Button btnadd;
        private Button btnremove;
        private Button btnEdit;
        private Button btnnext;
        private ListBox lstPackages;
        private ComboBox cmbpackagesbystate;
    }
}