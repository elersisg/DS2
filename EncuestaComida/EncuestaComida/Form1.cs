namespace EncuestaComida
{
    public partial class Form1 : Form
    {
        //Arreglo para almacenar los resultados  de 
        //la encuesta
        int[,] results = new int[4, 2];
        const int like = 0;
        const int dislike = 1;

        //Arreglo para el conjunto de comidas
        string[] foods = { "AAAAAAA".PadRight(10, Convert.ToChar(" ")), "BBBBBBBBB".PadRight(10, Convert.ToChar(" ")), "CCCC".PadRight(10, Convert.ToChar(" ")), "DDDD".PadRight(10, Convert.ToChar(" ")) };

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //Cargamos el arreglo foods en el combobox de comidas
            cbmFoods.DataSource = foods;
        }

        private void btnVote_Click(object sender, EventArgs e)
        {

            lstResults.Items.Clear();
            lstResults.Items.Add("Food".PadRight(10, Convert.ToChar(" ")) + "\t\tLike\t\tDislike");

            //Obtener el indice del elemento seleccionado
            //en el combobox

            int indice = cbmFoods.SelectedIndex;

            for (int row = 0; row < foods.Length; row++)
            {
                if (rbnLike.Checked && indice == row)
                {
                    results[row, like]++;
                }
                else if (rbnDislike.Checked && indice == row)
                {
                    results[row, dislike]++;
                }

                //mostramos el resultado
                lstResults.Items.Add(
                    foods[row] + "\t\t" + results[row, 0] +
                    "\t\t" + results[row, 1]
                    );
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < results.GetLength(0); row++)
            {
                for(int column = 0; column < results.GetLength(1); column++)
                {

                }
            }

            foreach (var item in results)
            {

            }
        }
    }
}