using Microsoft.VisualBasic;

namespace Interest_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;
        }

        private void btnCalculate_TextChanged(object sender, EventArgs e)
        {
            nudYears.Value = 5; nudYears.Enabled = false;

            if (double.TryParse(txtPrincipal.Text, out double capitalInicial) &&
                double.TryParse(txtInterestRate.Text, out double tasaInteres))
            {
                txtYearlyAccountBalance.Clear();

                double tasaInteresDecimal = tasaInteres / 100;

                for(int año = 1; año <= nudYears.Value; año++)
                {
                    double capitalfinal = Financial.FV(tasaInteresDecimal, año, 0, -capitalInicial);
                    double cambioINteres = capitalfinal - capitalInicial;
                    txtYearlyAccountBalance.AppendText($"Year {año}: Amount on deposit {cambioINteres:C}\r\n");
                }
            }
            else
            {
                txtYearlyAccountBalance.Text = "Please, enter the remaining values.";
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPrincipal_TextChanged(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length > 0 || txtInterestRate.Text.Length > 0) 
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled= false;
            }
        }

        private void txtInterestRate_TextChanged(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length > 0 || txtInterestRate.Text.Length > 0)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }
    }
}