namespace Fuzzy_Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;
            txtQuantityWhiteBlack.Text = "0";
            txtQuantityRedBlack.Text = "0";
            txtQuantityBlueBlack.Text = "0";
        }

        private void txtOrderNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 || txtAddress1.Text.Length > 0 || txtQuantityWhiteBlack.Text.Length > 0 || txtQuantityRedBlack.Text.Length > 0 || txtQuantityBlueBlack.Text.Length > 0)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const double precioWhiteBlack = 6.25;
            const double precioRedBlack = 5.00;
            const double precioBlueBlack = 7.50;

            const double tasaimpuestos = 0.05;
            const double shipping = 1.50;
            const double discountover500 = 0.07;
            double monto = 0;
            string message = "You have chosen \n\r\t";

            //Validar cuando los checkbox se encuentren marcados 

            if (chkWhiteBlack.Checked)
            {
                monto = monto += 6.25;
                message = message + chkWhiteBlack.Text + "\n\r\t";
            }

            if (chkRedBlack.Checked)
            {
                monto = monto += 5.00;
                message = message + chkRedBlack.Text + "\n\r\t";
            }
            if (chkBlueBlack.Checked)
            {
                monto = monto += 7.50;
                message = message + chkBlueBlack.Text + "\n\r\t";
            }

            //Cantidad de items al principio de la seleccion

            uint numWhiteBlack = 0;
            uint numRedBlack = 0;
            uint numBlueBlack = 0;

            double subtotalWhiteBlack = 0;
            double subtotalRedBlack = 0;
            double subtotalBlueBlack = 0;

            //Variables para los calculos finales 
            double totalWhiteBlack, totalRedBlack, totalBlueBlack, subtotal, tax, finaldiscount, totalfinal;

            numWhiteBlack = Convert.ToUInt32(txtQuantityWhiteBlack.Text);
            numRedBlack = Convert.ToUInt32(txtQuantityRedBlack.Text);
            numBlueBlack = Convert.ToUInt32(txtQuantityBlueBlack.Text);
            totalWhiteBlack = precioWhiteBlack * numWhiteBlack;
            totalRedBlack = precioRedBlack * numRedBlack;
            totalBlueBlack = precioBlueBlack * numBlueBlack;

            //Total de los productos seleccionados 

            subtotal = totalWhiteBlack + totalRedBlack + totalBlueBlack;

            //Impuestos aplicados a la venta

            tax = subtotal * tasaimpuestos;


            //Gastos de envio 

            double gastosEnvio = numWhiteBlack + numRedBlack + numBlueBlack <= 20 ? shipping * (numWhiteBlack + numRedBlack + numBlueBlack) : 0;

            //Total del pedido sin aplicar descuento

            double totalsindescuento = subtotal + tax + gastosEnvio;

            //Descuento si el pedido es mayor a 500 dolares  

            finaldiscount = totalsindescuento > 500 ? totalsindescuento * discountover500 : 0;

            //Total final con descuento 
            totalfinal = totalsindescuento - finaldiscount;

            //Enviar los valores a imprimir en el sistema 

            txtTotalWhiteBlack.Text = string.Format("{0:C}", totalWhiteBlack);
            txtTotalWhiteBlack.Text = totalWhiteBlack.ToString("C");

            txtTotalRedBlack.Text = string.Format("{0:C}", totalRedBlack);
            txtTotalRedBlack.Text = totalRedBlack.ToString("C");

            txtTotalBlueBlack.Text = string.Format("{0:C}", totalBlueBlack);
            txtTotalBlueBlack.Text = totalBlueBlack.ToString("C");

            txtSubtotal.Text = string.Format("{0:C}", subtotal);
            txtSubtotal.Text = subtotal.ToString("C");

            txtTax.Text = string.Format("{0:C}", tax);
            txtTax.Text = tax.ToString("C");

            txtShipping.Text = string.Format("{0:C}", gastosEnvio);
            txtShipping.Text = gastosEnvio.ToString("C");


            txtDiscount.Text = string.Format("{0:C}", finaldiscount);
            txtDiscount.Text = finaldiscount.ToString("C");

            txtTotal.Text = string.Format("{0:C}", totalfinal);
            txtTotal.Text = totalfinal.ToString("C");

            MessageBox.Show("7% discount will be applied", "Discount Offer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            

        }

        private void btnOrderNumber_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int randomNumber = random.Next(1000, 10000);

            txtOrderNumber.Text = randomNumber.ToString();
        }

        private void txtAddress1_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 || txtAddress1.Text.Length > 0 || txtQuantityWhiteBlack.Text.Length > 0 || txtQuantityRedBlack.Text.Length > 0 || txtQuantityBlueBlack.Text.Length > 0)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void txtQuantityBlueBlack_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 || txtAddress1.Text.Length > 0 || txtQuantityWhiteBlack.Text.Length > 0 || txtQuantityRedBlack.Text.Length > 0 || txtQuantityBlueBlack.Text.Length > 0)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void txtAddress2_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 || txtAddress1.Text.Length > 0 || txtQuantityWhiteBlack.Text.Length > 0 || txtQuantityRedBlack.Text.Length > 0 || txtQuantityBlueBlack.Text.Length > 0)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void txtAddress3_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 || txtAddress1.Text.Length > 0 || txtQuantityWhiteBlack.Text.Length > 0 || txtQuantityRedBlack.Text.Length > 0 || txtQuantityBlueBlack.Text.Length > 0)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void txtQuantityWhiteBlack_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 || txtAddress1.Text.Length > 0 || txtQuantityWhiteBlack.Text.Length > 0 || txtQuantityRedBlack.Text.Length > 0 || txtQuantityBlueBlack.Text.Length > 0)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void txtQuantityRedBlack_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 || txtAddress1.Text.Length > 0 || txtQuantityWhiteBlack.Text.Length > 0 || txtQuantityRedBlack.Text.Length > 0 || txtQuantityBlueBlack.Text.Length > 0)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void chkWhiteBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhiteBlack.Checked || chkRedBlack.Checked || chkBlueBlack.Checked)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void chkRedBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhiteBlack.Checked || chkRedBlack.Checked || chkBlueBlack.Checked)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void chkBlueBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhiteBlack.Checked || chkRedBlack.Checked || chkBlueBlack.Checked)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtShipping_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}