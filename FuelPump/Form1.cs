namespace FuelPump
{
    public partial class Form1 : Form
    {
        double regular = 2.00;
        double premium = 2.50;
        double Spremium = 5.80;
        double txtgalones = 0;
        string cantidad = "";
        int almacenamientogalones = 300;
        bool btonRegular = false;
        bool btonPremium = false;
        bool btonSpremium = false;
        double regulargalones = 300;
        double premiumgalones = 300;
        double Spremiumgalones = 300;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            txtCantidadGalones.BackColor = Color.DarkGreen;

            txtgalones = 0;
            cantidad = "";
            btonRegular = false;
            btonPremium = false;
            btonSpremium= false;
            regular = 2.00;

            cantidad = Microsoft.VisualBasic.Interaction.InputBox("Redacte la cantidad de galones a servir. Maximo: " + regulargalones, "Cuadro de entrada");

            if (!string.IsNullOrEmpty(cantidad))
            {
                if (double.TryParse(cantidad, out double cantidadNumerica) && cantidadNumerica > 0)
                {
                    if (cantidadNumerica > almacenamientogalones)
                    {
                        MessageBox.Show("La cantidad debe de ser menor o igual a 300 galones ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DialogResult result = MessageBox.Show("Estás seguro de esta cantidad? \n Cantidad: " + cantidad, "Cantidad ingresada", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        txtCantidadGalones.Clear();
                        txtPrecioGalones.Clear();

                        double CantidadDigitada = double.Parse(cantidad);
                        if(regulargalones > CantidadDigitada)
                        {
                            regulargalones = (int)(regulargalones - CantidadDigitada);
                            timer1.Start();
                            btonRegular = true;

                        }
                        else
                        {
                            MessageBox.Show("Se han agotado esa cantidad de suministros de: \n Gasolina Regular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (result == DialogResult.No)
                    {

                    }
                
                }
                else
                {
                    MessageBox.Show("Debe ingresar un número positivo en el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Debe ingresar un número en el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btonRegular)
            {
                double cantidadTimerR = double.Parse(cantidad);
                btnRegular.Enabled = false;
                btnPremium.Enabled = false;
                btnSuperPremium.Enabled = false;

                txtgalones++;


                txtCantidadGalones.Text = txtgalones.ToString("0.00");
                txtPrecioGalones.Text = "$" + regular.ToString("0.00");

                regular = regular + 2.00;

                if (txtgalones == cantidadTimerR)
                {
                    timer1.Stop();
                    MessageBox.Show("Se ha completado el proceso correctamente. \n Cantidad de galones restante: " + regulargalones, "Resultado del proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRegular.Enabled = true;
                    btnPremium.Enabled = true;
                    btnSuperPremium.Enabled = true;
                }
            }

            if (btonPremium)
            {
                double cantidadTimerP = double.Parse(cantidad);
                btnRegular.Enabled = false;
                btnPremium.Enabled = false;
                btnSuperPremium.Enabled = false;

                txtgalones++;


                txtCantidadGalones.Text = txtgalones.ToString("0.00");
                txtPrecioGalones.Text = "$" + premium.ToString("0.00");

                premium = premium + 2.50;

                if (txtgalones == cantidadTimerP)
                {
                    timer1.Stop();
                    MessageBox.Show("Se ha completado el proceso correctamente. \n Cantidad de galones restante: " + premiumgalones, "Resultado del proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRegular.Enabled = true;
                    btnPremium.Enabled = true;
                    btnSuperPremium.Enabled = true;
                }
            }

            if (btonSpremium)
            {
                double cantidadTimerS = double.Parse(cantidad);
                btnRegular.Enabled = false;
                btnPremium.Enabled = false;
                btnSuperPremium.Enabled = false;

                txtgalones++;


                txtCantidadGalones.Text = txtgalones.ToString("0.00");
                txtPrecioGalones.Text = "$" + Spremium.ToString("0.00");

                Spremium = Spremium + 5.80;

                if (txtgalones == cantidadTimerS)
                {
                    timer1.Stop();
                    MessageBox.Show("Se ha completado el proceso correctamente. \n Cantidad de galones restante: " + Spremiumgalones, "Resultado del proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRegular.Enabled = true;
                    btnPremium.Enabled = true;
                    btnSuperPremium.Enabled = true;
                }
            }
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            txtCantidadGalones.BackColor = Color.ForestGreen;

            txtgalones = 0;
            cantidad = "";
            btonRegular = false;
            btonPremium = false;
            btonSpremium = false;
            regular = 2.00;

            cantidad = Microsoft.VisualBasic.Interaction.InputBox("Redacte la cantidad de galones a servir. Maximo: " + premiumgalones, "Cuadro de entrada");

            if (!string.IsNullOrEmpty(cantidad))
            {
                if (double.TryParse(cantidad, out double cantidadNumerica) && cantidadNumerica > 0)
                {
                    if (cantidadNumerica > almacenamientogalones)
                    {
                        MessageBox.Show("La cantidad debe de ser menor o igual a 300 galones ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DialogResult result = MessageBox.Show("Estás seguro de esta cantidad? \n Cantidad: " + cantidad, "Cantidad ingresada", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        txtCantidadGalones.Clear();
                        txtPrecioGalones.Clear();

                        double CantidadDigitada = double.Parse(cantidad);
                        if (premiumgalones > CantidadDigitada)
                        {
                            premiumgalones = (int)(premiumgalones - CantidadDigitada);
                            timer1.Start();
                            btonPremium = true;

                        }
                        else
                        {
                            MessageBox.Show("Se han agotado esa cantidad de suministros de: \n Gasolina Regular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (result == DialogResult.No)
                    {

                    }

                }
                else
                {
                    MessageBox.Show("Debe ingresar un número positivo en el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Debe ingresar un número en el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuperPremium_Click(object sender, EventArgs e)
        {
            txtCantidadGalones.BackColor = Color.LightGreen;

            txtgalones = 0;
            cantidad = "";
            btonRegular = false;
            btonPremium = false;
            btonSpremium = false;
            regular = 2.00;

            cantidad = Microsoft.VisualBasic.Interaction.InputBox("Redacte la cantidad de galones a servir. Maximo: " + Spremiumgalones, "Cuadro de entrada");

            if (!string.IsNullOrEmpty(cantidad))
            {
                if (double.TryParse(cantidad, out double cantidadNumerica) && cantidadNumerica > 0)
                {
                    if (cantidadNumerica > almacenamientogalones)
                    {
                        MessageBox.Show("La cantidad debe de ser menor o igual a 300 galones ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DialogResult result = MessageBox.Show("Estás seguro de esta cantidad? \n Cantidad: " + cantidad, "Cantidad ingresada", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        txtCantidadGalones.Clear();
                        txtPrecioGalones.Clear();

                        double CantidadDigitada = double.Parse(cantidad);
                        if (Spremiumgalones > CantidadDigitada)
                        {
                            Spremiumgalones = (int)(Spremiumgalones - CantidadDigitada);
                            timer1.Start();
                            btonSpremium = true;

                        }
                        else
                        {
                            MessageBox.Show("Se han agotado esa cantidad de suministros de: \n Gasolina Regular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (result == DialogResult.No)
                    {

                    }

                }
                else
                {
                    MessageBox.Show("Debe ingresar un número positivo en el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Debe ingresar un número en el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}