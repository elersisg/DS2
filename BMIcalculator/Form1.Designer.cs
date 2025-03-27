namespace BMIcalculator
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
            chkMujer = new CheckBox();
            chkHombre = new CheckBox();
            groupBox1 = new GroupBox();
            lblAltura = new Label();
            trackBar1 = new TrackBar();
            groupBox2 = new GroupBox();
            btndisminuiredad = new Button();
            btnincrementaredad = new Button();
            lblEdad = new Label();
            groupBox3 = new GroupBox();
            btndisminuirpeso = new Button();
            btnincrementarpeso = new Button();
            lblPeso = new Label();
            btncalcular = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 36);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de BMI ";
            // 
            // chkMujer
            // 
            chkMujer.Appearance = Appearance.Button;
            chkMujer.AutoSize = true;
            chkMujer.BackColor = Color.Cornsilk;
            chkMujer.Enabled = false;
            chkMujer.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            chkMujer.Location = new Point(378, 74);
            chkMujer.MaximumSize = new Size(1000, 1000);
            chkMujer.MinimumSize = new Size(120, 120);
            chkMujer.Name = "chkMujer";
            chkMujer.Size = new Size(138, 120);
            chkMujer.TabIndex = 2;
            chkMujer.Text = "Mujer";
            chkMujer.TextAlign = ContentAlignment.MiddleCenter;
            chkMujer.UseVisualStyleBackColor = false;
            chkMujer.CheckedChanged += chkMujer_CheckedChanged;
            // 
            // chkHombre
            // 
            chkHombre.Appearance = Appearance.Button;
            chkHombre.AutoSize = true;
            chkHombre.BackColor = Color.Cornsilk;
            chkHombre.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            chkHombre.Location = new Point(81, 74);
            chkHombre.MaximumSize = new Size(1000, 1000);
            chkHombre.MinimumSize = new Size(120, 120);
            chkHombre.Name = "chkHombre";
            chkHombre.Size = new Size(177, 120);
            chkHombre.TabIndex = 3;
            chkHombre.Text = "Hombre";
            chkHombre.TextAlign = ContentAlignment.MiddleCenter;
            chkHombre.UseVisualStyleBackColor = false;
            chkHombre.CheckedChanged += chkHombre_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAltura);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(92, 223);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 187);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Altura (cm)";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblAltura.Location = new Point(159, 115);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(95, 48);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "120";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(23, 43);
            trackBar1.Maximum = 220;
            trackBar1.Minimum = 120;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(367, 56);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 120;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btndisminuiredad);
            groupBox2.Controls.Add(btnincrementaredad);
            groupBox2.Controls.Add(lblEdad);
            groupBox2.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(65, 443);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(214, 213);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Edad";
            // 
            // btndisminuiredad
            // 
            btndisminuiredad.Location = new Point(130, 135);
            btndisminuiredad.Name = "btndisminuiredad";
            btndisminuiredad.Size = new Size(55, 49);
            btndisminuiredad.TabIndex = 3;
            btndisminuiredad.Text = "-";
            btndisminuiredad.UseVisualStyleBackColor = true;
            btndisminuiredad.Click += btndisminuiredad_Click;
            // 
            // btnincrementaredad
            // 
            btnincrementaredad.Location = new Point(41, 135);
            btnincrementaredad.Name = "btnincrementaredad";
            btnincrementaredad.Size = new Size(55, 49);
            btnincrementaredad.TabIndex = 2;
            btnincrementaredad.Text = "+";
            btnincrementaredad.UseVisualStyleBackColor = true;
            btnincrementaredad.Click += btnincrementaredad_Click;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEdad.Location = new Point(73, 58);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(68, 45);
            lblEdad.TabIndex = 0;
            lblEdad.Text = "18";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btndisminuirpeso);
            groupBox3.Controls.Add(btnincrementarpeso);
            groupBox3.Controls.Add(lblPeso);
            groupBox3.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(337, 443);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(214, 225);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Peso (Kg)";
            // 
            // btndisminuirpeso
            // 
            btndisminuirpeso.Location = new Point(124, 146);
            btndisminuirpeso.Name = "btndisminuirpeso";
            btndisminuirpeso.Size = new Size(55, 49);
            btndisminuirpeso.TabIndex = 4;
            btndisminuirpeso.Text = "-";
            btndisminuirpeso.UseVisualStyleBackColor = true;
            btndisminuirpeso.Click += btndisminuirpeso_Click;
            // 
            // btnincrementarpeso
            // 
            btnincrementarpeso.Location = new Point(28, 146);
            btnincrementarpeso.Name = "btnincrementarpeso";
            btnincrementarpeso.Size = new Size(55, 49);
            btnincrementarpeso.TabIndex = 3;
            btnincrementarpeso.Text = "+";
            btnincrementarpeso.UseVisualStyleBackColor = true;
            btnincrementarpeso.Click += btnincrementarpeso_Click;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPeso.Location = new Point(83, 70);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(68, 45);
            lblPeso.TabIndex = 1;
            lblPeso.Text = "60";
            // 
            // btncalcular
            // 
            btncalcular.BackColor = Color.SkyBlue;
            btncalcular.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btncalcular.Location = new Point(92, 684);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(396, 70);
            btncalcular.TabIndex = 5;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = false;
            btncalcular.Click += btncalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(609, 804);
            Controls.Add(btncalcular);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(chkHombre);
            Controls.Add(chkMujer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox chkMujer;
        private CheckBox chkHombre;
        private GroupBox groupBox1;
        private Label lblAltura;
        private TrackBar trackBar1;
        private GroupBox groupBox2;
        private Button btnincrementaredad;
        private Label lblEdad;
        private GroupBox groupBox3;
        private Button btndisminuirpeso;
        private Label lblPeso;
        private Button btndisminuiredad;
        private Button button4;
        private Button button3;
        private Button btnincrementarpeso;
        private Button btncalcular;
    }
}