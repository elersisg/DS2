namespace Loan_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Variables para calculos 

            double amount;
            double rate;
            int months;
            double fees;


            amount = Convert.ToDouble(txtLoanAmount.Text);
            months = Convert.ToInt32(txtDuration.Text);
            rate = Convert.ToDouble(txtInterestRate.Text);

            if (chkEarlyPayments.Checked)
            {
                fees = Microsoft.VisualBasic.Financial.Pmt(rate / 100 / 12, months, -amount, 0, Microsoft.VisualBasic.DueDate.BegOfPeriod);
            }
            else
            {
                fees = Microsoft.VisualBasic.Financial.Pmt(rate / 100 / 12, months, -amount, 0, Microsoft.VisualBasic.DueDate.EndOfPeriod);
            }

            txtMonthlyPayments.Text = fees.ToString("C");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLoanAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtLoanAmount.Text.Length > 0 || txtInterestRate.Text.Length > 0 || txtDuration.Text.Length > 0)
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtInterestRate_TextChanged(object sender, EventArgs e)
        {
            if (txtLoanAmount.Text.Length > 0 || txtInterestRate.Text.Length > 0 || txtDuration.Text.Length > 0)
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {
            if (txtLoanAmount.Text.Length > 0 || txtInterestRate.Text.Length > 0 || txtDuration.Text.Length > 0)
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void chkEarlyPayments_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}