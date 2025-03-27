namespace FuelPump
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
            label1 = new Label();
            label2 = new Label();
            txtCantidadGalones = new TextBox();
            txtPrecioGalones = new TextBox();
            btnRegular = new Button();
            btnPremium = new Button();
            btnSuperPremium = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de galones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Precio ";
            // 
            // txtCantidadGalones
            // 
            txtCantidadGalones.Location = new Point(158, 6);
            txtCantidadGalones.Name = "txtCantidadGalones";
            txtCantidadGalones.Size = new Size(125, 27);
            txtCantidadGalones.TabIndex = 2;
            // 
            // txtPrecioGalones
            // 
            txtPrecioGalones.BackColor = SystemColors.Info;
            txtPrecioGalones.Location = new Point(389, 6);
            txtPrecioGalones.Name = "txtPrecioGalones";
            txtPrecioGalones.Size = new Size(156, 27);
            txtPrecioGalones.TabIndex = 3;
            txtPrecioGalones.Text = "$0.00";
            txtPrecioGalones.TextAlign = HorizontalAlignment.Right;
            // 
            // btnRegular
            // 
            btnRegular.Location = new Point(65, 112);
            btnRegular.Name = "btnRegular";
            btnRegular.Size = new Size(107, 95);
            btnRegular.TabIndex = 4;
            btnRegular.Text = "Regular ";
            btnRegular.UseVisualStyleBackColor = true;
            btnRegular.Click += btnRegular_Click;
            // 
            // btnPremium
            // 
            btnPremium.Location = new Point(248, 112);
            btnPremium.Name = "btnPremium";
            btnPremium.Size = new Size(107, 95);
            btnPremium.TabIndex = 5;
            btnPremium.Text = "Premium";
            btnPremium.UseVisualStyleBackColor = true;
            btnPremium.Click += btnPremium_Click;
            // 
            // btnSuperPremium
            // 
            btnSuperPremium.Location = new Point(404, 112);
            btnSuperPremium.Name = "btnSuperPremium";
            btnSuperPremium.Size = new Size(107, 95);
            btnSuperPremium.TabIndex = 6;
            btnSuperPremium.Text = "Super Premium";
            btnSuperPremium.UseVisualStyleBackColor = true;
            btnSuperPremium.Click += btnSuperPremium_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 279);
            Controls.Add(btnSuperPremium);
            Controls.Add(btnPremium);
            Controls.Add(btnRegular);
            Controls.Add(txtPrecioGalones);
            Controls.Add(txtCantidadGalones);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCantidadGalones;
        private TextBox txtPrecioGalones;
        private Button btnRegular;
        private Button btnPremium;
        private Button btnSuperPremium;
        private System.Windows.Forms.Timer timer1;
    }
}