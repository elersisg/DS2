namespace EncuestaComida
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
            btnVote = new Button();
            rbnDislike = new RadioButton();
            rbnLike = new RadioButton();
            cbmFoods = new ComboBox();
            groupBox2 = new GroupBox();
            lstResults = new ListBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVote);
            groupBox1.Controls.Add(rbnDislike);
            groupBox1.Controls.Add(rbnLike);
            groupBox1.Controls.Add(cbmFoods);
            groupBox1.Location = new Point(26, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vote";
            // 
            // btnVote
            // 
            btnVote.Location = new Point(427, 37);
            btnVote.Name = "btnVote";
            btnVote.Size = new Size(123, 29);
            btnVote.TabIndex = 3;
            btnVote.Text = "Vote";
            btnVote.UseVisualStyleBackColor = true;
            btnVote.Click += btnVote_Click;
            // 
            // rbnDislike
            // 
            rbnDislike.AutoSize = true;
            rbnDislike.Location = new Point(318, 39);
            rbnDislike.Name = "rbnDislike";
            rbnDislike.Size = new Size(74, 24);
            rbnDislike.TabIndex = 2;
            rbnDislike.Text = "Dislike";
            rbnDislike.UseVisualStyleBackColor = true;
            // 
            // rbnLike
            // 
            rbnLike.AutoSize = true;
            rbnLike.Checked = true;
            rbnLike.Location = new Point(217, 39);
            rbnLike.Name = "rbnLike";
            rbnLike.Size = new Size(56, 24);
            rbnLike.TabIndex = 1;
            rbnLike.TabStop = true;
            rbnLike.Text = "Like";
            rbnLike.UseVisualStyleBackColor = true;
            // 
            // cbmFoods
            // 
            cbmFoods.FormattingEnabled = true;
            cbmFoods.Location = new Point(16, 35);
            cbmFoods.Name = "cbmFoods";
            cbmFoods.Size = new Size(177, 28);
            cbmFoods.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstResults);
            groupBox2.Location = new Point(26, 160);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(621, 225);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // lstResults
            // 
            lstResults.ColumnWidth = 10;
            lstResults.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lstResults.FormattingEnabled = true;
            lstResults.ItemHeight = 20;
            lstResults.Location = new Point(16, 40);
            lstResults.MultiColumn = true;
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(585, 144);
            lstResults.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(434, 426);
            button1.Name = "button1";
            button1.Size = new Size(142, 51);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 519);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Food Survey";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnVote;
        private RadioButton rbnDislike;
        private RadioButton rbnLike;
        private ComboBox cbmFoods;
        private GroupBox groupBox2;
        private ListBox lstResults;
        private Button button1;
    }
}