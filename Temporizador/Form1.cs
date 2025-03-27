namespace Temporizador
{
    public partial class Form1 : Form
    {
        private int horas, minutos, segundos;



        public Form1()
        {
            InitializeComponent();



        }

        private void ActualizarLabel()
        {
            labelTime.Text = $"{horas:D2}:{minutos:D2}:{segundos:D2}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelTime.Text = "1";

            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);

            //If para actualizar las horas, minutos y segundos en orden

            if (segundos < 10)
            {
                segundos = segundos * 10 + numero;
            }
            else if (minutos < 10)
            {
                minutos = minutos * 10 + numero;
            }
            else if (horas < 10)
            {
                horas = horas * 10 + numero;
            }

            ActualizarLabel();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //Actualizar el tiempo restnate y el label en cada tick del temporizador 
            if (segundos > 0)
            {
                segundos--;
            }
            else if (minutos > 0)
            {
                minutos--;
                segundos = 59;
            }
            else if (horas > 0)
            {
                horas--;
                minutos = 59;
                segundos = 59;
            }

            ActualizarLabel();

            //If para cuando el tiempo se acabe mostrar un mensaje avisandolo  

            if (horas == 0 && minutos == 0 && segundos == 0)
            {
                timer1.Stop(); // Detener el temporizador cuando el tiempo se agota
                MessageBox.Show("Tiempo agotado");
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelGeneral.BackColor = Color.Yellow;

            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            panelGeneral.BackColor = Color.WhiteSmoke;

            timer1.Stop();
        }

        private void panelGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            labelTime.Text = "2";

            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);

            if (segundos < 10)
            {
                segundos = segundos * 10 + numero;
            }
            else if (minutos < 10)
            {
                minutos = minutos * 10 + numero;
            }
            else if (horas < 10)
            {
                horas = horas * 10 + numero;
            }

            ActualizarLabel();


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            labelTime.Text = "3";

            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);

            if (segundos < 10)
            {
                segundos = segundos * 10 + numero;
            }
            else if (minutos < 10)
            {
                minutos = minutos * 10 + numero;
            }
            else if (horas < 10)
            {
                horas = horas * 10 + numero;
            }

            ActualizarLabel();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            labelTime.Text = "4";

            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);

            if (segundos < 10)
            {
                segundos = segundos * 10 + numero;
            }
            else if (minutos < 10)
            {
                minutos = minutos * 10 + numero;
            }
            else if (horas < 10)
            {
                horas = horas * 10 + numero;
            }

            ActualizarLabel();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            labelTime.Text = "5";

            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);

            if (segundos < 10)
            {
                segundos = segundos * 10 + numero;
            }
            else if (minutos < 10)
            {
                minutos = minutos * 10 + numero;
            }
            else if (horas < 10)
            {
                horas = horas * 10 + numero;
            }

            ActualizarLabel();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            labelTime.Text = "6";

            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);

            if (segundos < 10)
            {
                segundos = segundos * 10 + numero;
            }
            else if (minutos < 10)
            {
                minutos = minutos * 10 + numero;
            }
            else if (horas < 10)
            {
                horas = horas * 10 + numero;
            }

            ActualizarLabel();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            labelTime.Text = "7";

            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);

            if (segundos < 10)
            {
                segundos = segundos * 10 + numero;
            }
            else if (minutos < 10)
            {
                minutos = minutos * 10 + numero;
            }
            else if (horas < 10)
            {
                horas = horas * 10 + numero;
            }

            ActualizarLabel();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            labelTime.Text = "8";

            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);

            if (segundos < 10)
            {
                segundos = segundos * 10 + numero;
            }
            else if (minutos < 10)
            {
                minutos = minutos * 10 + numero;
            }
            else if (horas < 10)
            {
                horas = horas * 10 + numero;
            }

            ActualizarLabel();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            labelTime.Text = "9";

            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);

            if (segundos < 10)
            {
                segundos = segundos * 10 + numero;
            }
            else if (minutos < 10)
            {
                minutos = minutos * 10 + numero;
            }
            else if (horas < 10)
            {
                horas = horas * 10 + numero;
            }

            ActualizarLabel();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            labelTime.Text = "0";

            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);

            if (segundos < 10)
            {
                segundos = segundos * 10 + numero;
            }
            else if (minutos < 10)
            {
                minutos = minutos * 10 + numero;
            }
            else if (horas < 10)
            {
                horas = horas * 10 + numero;
            }

            ActualizarLabel();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}