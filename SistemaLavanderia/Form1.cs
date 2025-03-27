namespace SistemaLavanderia
{
    public partial class Form1 : Form
    {
        //constantes con los precios
        const double precioUnaCamisa = 0.75;
        const double precioUnPantalon = 2.25;
        const double precioUnVestido = 4.76;

        const double ITBIS = 0.18;

        public Form1()
        {
            InitializeComponent();
            dtpFecha.MinDate = DateTime.Now;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaramos las variables para los datos del cliente
            string nombreCliente;
            string telefonoCliente;
            DateTime fechaOrden;



            //Declaramos variables para almacenar las cantidades de los
            //itemes a procesar
            uint cantidadCamisas = 0;
            uint cantidadVestidos = 0;
            uint cantidadPantalones = 0;

            //declarar variables para los calculos
            double subTotalCamisas = 0;
            double subTotalPantalones = 0;
            double subTotalVestidos = 0;

            double totalBruto, totalNeto, impuestos, valorPagado, devuelta;

            if (Microsoft.VisualBasic.Information.IsNumeric(txtCantidadPantalones))
            {
                MessageBox.Show("Error, el valor debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Microsoft.VisualBasic.Information.IsNumeric(txtCantidadVestidos))
            {
                MessageBox.Show("Error, el valor debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Microsoft.VisualBasic.Information.IsNumeric(txtTelefonoCliente))
            {
                MessageBox.Show("Error, el valor debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            try
            {
                cantidadCamisas = Convert.ToUInt32(txtCantidadCamisas.Text);
                cantidadPantalones = Convert.ToUInt32(txtCantidadPantalones.Text);
                cantidadVestidos = Convert.ToUInt32(txtCantidadVestidos.Text);
                subTotalCamisas = cantidadCamisas * precioUnaCamisa;
                subTotalPantalones = cantidadPantalones * precioUnPantalon;
                subTotalVestidos = cantidadVestidos * precioUnVestido;

                totalBruto = subTotalCamisas + subTotalPantalones + subTotalVestidos;

                //impuestos a pagar
                impuestos = totalBruto * ITBIS;

                //total neto
                totalNeto = totalBruto + ITBIS;

                //Comunicar al usuario el valor total de la factura
                MessageBox.Show(string.Format("El Total de la factura es {0:C}", totalNeto), "Total Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Pedimos que pague
                valorPagado = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Introduzca el pago del Cliente:"));

                //calcular la diferencia
                devuelta = valorPagado - totalNeto;

                //Mostrar el resumen de la factura

                txtmostrarcliente.Text = string.Format(txtNombreCliente.Text);

                txtmostrartelefono.Text = string.Format(txtmostrartelefono.Text);

                txtmostrarfecha.Text = string.Format(txtmostrarfecha.Text);

                txtCantidadCamisas.Text = string.Format(txtmostrarcamisas.Text);

                txtCantidadPantalones.Text = string.Format(txtmostrarpantalones.Text);

                txtCantidadVestidos.Text = string.Format(txtmostrarvestidos.Text);

                txtSubtotal.Text = string.Format("{0:C}", totalBruto);
                txtSubtotal.Text = totalBruto.ToString("C");

                txtImpuestos.Text = string.Format("{0:C}", impuestos);
                txtImpuestos.Text = impuestos.ToString("C");

                txtTotalOrden.Text = string.Format("{0:C}", totalNeto);
                txtTotalOrden.Text = totalNeto.ToString("C");


                txtpago.Text = string.Format("{0:C}", valorPagado);
                txtpago.Text = valorPagado.ToString("C");

                txtdiferencia.Text = string.Format("{0:C}", devuelta);
                txtdiferencia.Text = devuelta.ToString("C");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, el valor debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtTelefonoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //salir de la aplicacion
            Application.Exit();
        }

        private void txtCantidadCamisas_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidadCamisas.TextLength > 0)
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidadVestidos_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidadVestidos.TextLength > 0)
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtCantidadPantalones_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidadPantalones.TextLength > 0)
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmostrarcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                
                e.Handled = true;
            }
        }
    }
}