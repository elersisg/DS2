namespace SistemaLavanderia
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1 = new GroupBox();
            dtpFecha = new DateTimePicker();
            txtTelefonoCliente = new TextBox();
            txtNombreCliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtCantidadVestidos = new TextBox();
            txtCantidadPantalones = new TextBox();
            txtCantidadCamisas = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            txtdiferencia = new TextBox();
            txtpago = new TextBox();
            txtTotalOrden = new TextBox();
            txtImpuestos = new TextBox();
            txtSubtotal = new TextBox();
            txtmostrarvestidos = new TextBox();
            txtmostrarpantalones = new TextBox();
            txtmostrarcamisas = new TextBox();
            txtmostrarfecha = new TextBox();
            txtmostrartelefono = new TextBox();
            txtmostrarcliente = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnCalcular = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(txtTelefonoCliente);
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 198);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(136, 131);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(299, 25);
            dtpFecha.TabIndex = 5;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(153, 79);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(213, 25);
            txtTelefonoCliente.TabIndex = 4;
            txtTelefonoCliente.TextChanged += txtTelefonoCliente_TextChanged;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(161, 30);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(205, 25);
            txtNombreCliente.TabIndex = 3;
            txtNombreCliente.TextChanged += txtNombreCliente_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 127);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 2;
            label3.Text = "Fecha Orden";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 79);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 1;
            label2.Text = "Telefono cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 32);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre Cliente";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCantidadVestidos);
            groupBox2.Controls.Add(txtCantidadPantalones);
            groupBox2.Controls.Add(txtCantidadCamisas);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(19, 252);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 210);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la factura";
            // 
            // txtCantidadVestidos
            // 
            txtCantidadVestidos.Location = new Point(109, 149);
            txtCantidadVestidos.Name = "txtCantidadVestidos";
            txtCantidadVestidos.Size = new Size(228, 25);
            txtCantidadVestidos.TabIndex = 5;
            txtCantidadVestidos.TextChanged += txtCantidadVestidos_TextChanged;
            // 
            // txtCantidadPantalones
            // 
            txtCantidadPantalones.Location = new Point(109, 104);
            txtCantidadPantalones.Name = "txtCantidadPantalones";
            txtCantidadPantalones.Size = new Size(235, 25);
            txtCantidadPantalones.TabIndex = 4;
            txtCantidadPantalones.TextChanged += txtCantidadPantalones_TextChanged;
            // 
            // txtCantidadCamisas
            // 
            txtCantidadCamisas.Location = new Point(94, 50);
            txtCantidadCamisas.Name = "txtCantidadCamisas";
            txtCantidadCamisas.Size = new Size(250, 25);
            txtCantidadCamisas.TabIndex = 3;
            txtCantidadCamisas.TextChanged += txtCantidadCamisas_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 149);
            label6.Name = "label6";
            label6.Size = new Size(60, 17);
            label6.TabIndex = 2;
            label6.Text = "Vestidos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 103);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 1;
            label5.Text = "Pantalones:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 49);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 0;
            label4.Text = "Camisas:";
            label4.Click += label4_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtdiferencia);
            groupBox3.Controls.Add(txtpago);
            groupBox3.Controls.Add(txtTotalOrden);
            groupBox3.Controls.Add(txtImpuestos);
            groupBox3.Controls.Add(txtSubtotal);
            groupBox3.Controls.Add(txtmostrarvestidos);
            groupBox3.Controls.Add(txtmostrarpantalones);
            groupBox3.Controls.Add(txtmostrarcamisas);
            groupBox3.Controls.Add(txtmostrarfecha);
            groupBox3.Controls.Add(txtmostrartelefono);
            groupBox3.Controls.Add(txtmostrarcliente);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(483, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(465, 482);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resumen";
            // 
            // txtdiferencia
            // 
            txtdiferencia.Location = new Point(147, 449);
            txtdiferencia.Name = "txtdiferencia";
            txtdiferencia.Size = new Size(283, 25);
            txtdiferencia.TabIndex = 24;
            txtdiferencia.TextAlign = HorizontalAlignment.Right;
            // 
            // txtpago
            // 
            txtpago.Location = new Point(151, 417);
            txtpago.Name = "txtpago";
            txtpago.Size = new Size(279, 25);
            txtpago.TabIndex = 23;
            txtpago.TextAlign = HorizontalAlignment.Right;
            txtpago.TextChanged += txtpago_TextChanged;
            // 
            // txtTotalOrden
            // 
            txtTotalOrden.Location = new Point(152, 382);
            txtTotalOrden.Name = "txtTotalOrden";
            txtTotalOrden.Size = new Size(278, 25);
            txtTotalOrden.TabIndex = 22;
            txtTotalOrden.TextAlign = HorizontalAlignment.Right;
            // 
            // txtImpuestos
            // 
            txtImpuestos.Location = new Point(152, 343);
            txtImpuestos.Name = "txtImpuestos";
            txtImpuestos.Size = new Size(278, 25);
            txtImpuestos.TabIndex = 21;
            txtImpuestos.TextAlign = HorizontalAlignment.Right;
            txtImpuestos.TextChanged += textBox13_TextChanged;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(153, 307);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(277, 25);
            txtSubtotal.TabIndex = 20;
            txtSubtotal.TextAlign = HorizontalAlignment.Right;
            txtSubtotal.TextChanged += textBox12_TextChanged;
            // 
            // txtmostrarvestidos
            // 
            txtmostrarvestidos.Location = new Point(152, 251);
            txtmostrarvestidos.Name = "txtmostrarvestidos";
            txtmostrarvestidos.Size = new Size(282, 25);
            txtmostrarvestidos.TabIndex = 19;
            txtmostrarvestidos.TextAlign = HorizontalAlignment.Right;
            // 
            // txtmostrarpantalones
            // 
            txtmostrarpantalones.Location = new Point(153, 218);
            txtmostrarpantalones.Name = "txtmostrarpantalones";
            txtmostrarpantalones.Size = new Size(283, 25);
            txtmostrarpantalones.TabIndex = 18;
            txtmostrarpantalones.TextAlign = HorizontalAlignment.Right;
            // 
            // txtmostrarcamisas
            // 
            txtmostrarcamisas.Location = new Point(154, 185);
            txtmostrarcamisas.Name = "txtmostrarcamisas";
            txtmostrarcamisas.Size = new Size(282, 25);
            txtmostrarcamisas.TabIndex = 17;
            // 
            // txtmostrarfecha
            // 
            txtmostrarfecha.Location = new Point(152, 140);
            txtmostrarfecha.Name = "txtmostrarfecha";
            txtmostrarfecha.Size = new Size(284, 25);
            txtmostrarfecha.TabIndex = 16;
            // 
            // txtmostrartelefono
            // 
            txtmostrartelefono.Location = new Point(152, 102);
            txtmostrartelefono.Name = "txtmostrartelefono";
            txtmostrartelefono.Size = new Size(284, 25);
            txtmostrartelefono.TabIndex = 15;
            // 
            // txtmostrarcliente
            // 
            txtmostrarcliente.Location = new Point(155, 64);
            txtmostrarcliente.Name = "txtmostrarcliente";
            txtmostrarcliente.Size = new Size(281, 25);
            txtmostrarcliente.TabIndex = 14;
            txtmostrarcliente.TextChanged += txtmostrarcliente_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(20, 445);
            label20.Name = "label20";
            label20.Size = new Size(70, 17);
            label20.TabIndex = 13;
            label20.Text = "Diferencia";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(20, 417);
            label19.Name = "label19";
            label19.Size = new Size(38, 17);
            label19.TabIndex = 12;
            label19.Text = "Pago";
            label19.Click += label19_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(19, 383);
            label18.Name = "label18";
            label18.Size = new Size(74, 17);
            label18.TabIndex = 11;
            label18.Text = "Total orden";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(20, 343);
            label17.Name = "label17";
            label17.Size = new Size(68, 17);
            label17.TabIndex = 10;
            label17.Text = "Impuestos";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(20, 310);
            label16.Name = "label16";
            label16.Size = new Size(55, 17);
            label16.TabIndex = 9;
            label16.Text = "Subtotal";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(7, 276);
            label15.Name = "label15";
            label15.Size = new Size(383, 17);
            label15.TabIndex = 8;
            label15.Text = "---------------------------------------------------------------------------";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 249);
            label14.Name = "label14";
            label14.Size = new Size(60, 17);
            label14.TabIndex = 7;
            label14.Text = "Vestidos:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 217);
            label13.Name = "label13";
            label13.Size = new Size(75, 17);
            label13.TabIndex = 6;
            label13.Text = "Pantalones:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 184);
            label12.Name = "label12";
            label12.Size = new Size(61, 17);
            label12.TabIndex = 5;
            label12.Text = "Camisas:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 164);
            label11.Name = "label11";
            label11.Size = new Size(383, 17);
            label11.TabIndex = 4;
            label11.Text = "---------------------------------------------------------------------------";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 134);
            label10.Name = "label10";
            label10.Size = new Size(116, 17);
            label10.TabIndex = 3;
            label10.Text = "Fecha de la orden:";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 102);
            label9.Name = "label9";
            label9.Size = new Size(104, 17);
            label9.TabIndex = 2;
            label9.Text = "Telefono cliente:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 65);
            label8.Name = "label8";
            label8.Size = new Size(104, 17);
            label8.TabIndex = 1;
            label8.Text = "Nombre Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(95, 23);
            label7.Name = "label7";
            label7.Size = new Size(279, 29);
            label7.TabIndex = 0;
            label7.Text = "Resumen de la factura";
            label7.Click += label7_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(483, 513);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(462, 53);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(480, 572);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(465, 59);
            btnExit.TabIndex = 15;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 643);
            Controls.Add(btnExit);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox3;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label15;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Button btnCalcular;
        private Button btnExit;
        private DateTimePicker dtpFecha;
        private TextBox txtTelefonoCliente;
        private TextBox txtNombreCliente;
        private TextBox txtCantidadVestidos;
        private TextBox txtCantidadPantalones;
        private TextBox txtCantidadCamisas;
        private TextBox txtImpuestos;
        private TextBox txtSubtotal;
        private TextBox txtmostrarvestidos;
        private TextBox txtmostrarpantalones;
        private TextBox txtmostrarcamisas;
        private TextBox txtmostrarfecha;
        private TextBox txtmostrartelefono;
        private TextBox txtmostrarcliente;
        private TextBox txtdiferencia;
        private TextBox txtpago;
        private TextBox txtTotalOrden;
    }
}