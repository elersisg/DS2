namespace Temporizador
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
            components = new System.ComponentModel.Container();
            panelGeneral = new Panel();
            panel2 = new Panel();
            labelTime = new Label();
            btnStart = new Button();
            btn0 = new Button();
            btnStop = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panelGeneral.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelGeneral
            // 
            panelGeneral.BackColor = Color.WhiteSmoke;
            panelGeneral.Controls.Add(panel2);
            panelGeneral.Controls.Add(btnStart);
            panelGeneral.Controls.Add(btn0);
            panelGeneral.Controls.Add(btnStop);
            panelGeneral.Controls.Add(btn7);
            panelGeneral.Controls.Add(btn8);
            panelGeneral.Controls.Add(btn9);
            panelGeneral.Controls.Add(btn4);
            panelGeneral.Controls.Add(btn5);
            panelGeneral.Controls.Add(btn6);
            panelGeneral.Controls.Add(btn3);
            panelGeneral.Controls.Add(btn2);
            panelGeneral.Controls.Add(btn1);
            panelGeneral.Location = new Point(0, 0);
            panelGeneral.Name = "panelGeneral";
            panelGeneral.Size = new Size(810, 674);
            panelGeneral.TabIndex = 0;
            panelGeneral.Paint += panelGeneral_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelTime);
            panel2.Location = new Point(86, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(604, 125);
            panel2.TabIndex = 12;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.Location = new Point(170, 19);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(277, 81);
            labelTime.TabIndex = 0;
            labelTime.Text = "00:00:00";
            labelTime.Click += labelTime_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(487, 510);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(88, 76);
            btnStart.TabIndex = 11;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(349, 510);
            btn0.Name = "btn0";
            btn0.Size = new Size(88, 76);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(215, 510);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(88, 76);
            btnStop.TabIndex = 9;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(215, 399);
            btn7.Name = "btn7";
            btn7.Size = new Size(88, 76);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(349, 399);
            btn8.Name = "btn8";
            btn8.Size = new Size(88, 76);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(487, 399);
            btn9.Name = "btn9";
            btn9.Size = new Size(88, 76);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(215, 286);
            btn4.Name = "btn4";
            btn4.Size = new Size(88, 76);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(349, 299);
            btn5.Name = "btn5";
            btn5.Size = new Size(88, 76);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(487, 299);
            btn6.Name = "btn6";
            btn6.Size = new Size(88, 76);
            btn6.TabIndex = 3;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(487, 186);
            btn3.Name = "btn3";
            btn3.Size = new Size(88, 76);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(349, 186);
            btn2.Name = "btn2";
            btn2.Size = new Size(88, 76);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(215, 186);
            btn1.Name = "btn1";
            btn1.Size = new Size(88, 76);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 636);
            Controls.Add(panelGeneral);
            Name = "Form1";
            Text = "Form1";
            panelGeneral.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGeneral;
        private Button btn1;
        private Panel panel2;
        private Label labelTime;
        private Button btnStart;
        private Button btn0;
        private Button btnStop;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn3;
        private Button btn2;
        private System.Windows.Forms.Timer timer1;
    }
}