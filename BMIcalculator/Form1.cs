namespace BMIcalculator
{
    public partial class Form1 : Form
    {
        int edad = 18;
        int peso = 60;
        int altura = 120;
        public Form1()
        {
            InitializeComponent();
            lblEdad.Text = edad.ToString();
            lblPeso.Text = peso.ToString();
            lblAltura.Text = altura.ToString();
        }

        private void chkMujer_CheckedChanged(object sender, EventArgs e)
        {
            chkHombre.Checked = false;
            chkHombre.BackColor = Color.White;
            chkMujer.BackColor = Color.Cornsilk;


        }

        private void chkHombre_CheckedChanged(object sender, EventArgs e)
        {
            chkMujer.Checked = false;
            chkMujer.BackColor = Color.White;
            chkHombre.BackColor = Color.Cornsilk;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblAltura.Text = trackBar1.Value.ToString();
        }

        private void btnincrementaredad_Click(object sender, EventArgs e)
        {
            edad++;
            lblEdad.Text = edad.ToString();

        }

        private void btndisminuiredad_Click(object sender, EventArgs e)
        {
            edad--;
            lblEdad.Text = edad.ToString();

        }

        private void btnincrementarpeso_Click(object sender, EventArgs e)
        {
            peso++;
            lblPeso.Text = peso.ToString();

        }

        private void btndisminuirpeso_Click(object sender, EventArgs e)
        {
            peso--;

            lblPeso.Text = peso.ToString();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double alturaenmetros = (double)trackBar1.Value / 100;

            double imc = peso / (alturaenmetros * alturaenmetros);

            if (chkHombre.Checked || chkMujer.Checked)
            {

                MessageBox.Show("Su indice de masa corporal es " + imc);

            }
            else
            {
                MessageBox.Show("Aun no has seleccionado un sexo");
            }
            string resultado;
            string consejo;

            if (imc < 18.5)
            {
                resultado = "Tiene un peso bajo (delgado).";
                consejo = "Debes de alimentarte mejor";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                resultado = "Tiene un buen peso.";
                consejo = "Realiza ejercicio y mantente como estas.";
            }
            else
            {
                resultado = "Está en sobrepeso";
                consejo = "Reduce la cantidad de comida chatarra que consumes";
            }
        }
    }
}