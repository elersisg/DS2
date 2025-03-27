namespace Programmer_s_Shopping_Cart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCalculate.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            string message = "You purchased \n\r\t";
            string paymentmode = "Your payment mode is";
            int monto = 0;

            //Validar cuando los checkbox se encuentren marcados:

            if (chkCsharpHowToProgram.Checked)
            {
                monto = monto += 50;
                message = message + chkCsharpHowToProgram.Text + "\n\r\t";

            }

            if (chkCsharpForProgrammers.Checked)
            {
                monto = monto += 30;
                message = message + chkCsharpForProgrammers.Text + "\n\r\t";
            }
            if (chkCsharpSchool.Checked)
            {
                monto = monto += 20;
                message = message + chkCsharpSchool.Text + "\r\n\t";
            }
            // Concatenar el total del servicio 

            if (rbtnFullPayment.Checked)
            {
                paymentmode += rbtnFullPayment.Text;
            }
            else
            {
                paymentmode += rbtnInstantPayment.Text;
            }

            message += "\n\n" + paymentmode;

            //Determinar si se escribio un comentario

            if (txtComments.TextLength > 0)
            {
                message += "\n\nYour comments to us are: " + txtComments.Text;
            }
            
            MessageBox.Show(message, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkCsharpHowToProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCsharpForProgrammers.Checked || chkCsharpHowToProgram.Checked || chkCsharpSchool.Checked)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void chkCsharpForProgrammers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCsharpForProgrammers.Checked || chkCsharpHowToProgram.Checked || chkCsharpSchool.Checked)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void chkCsharpSchool_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCsharpForProgrammers.Checked || chkCsharpHowToProgram.Checked || chkCsharpSchool.Checked)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnFullPayment_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}