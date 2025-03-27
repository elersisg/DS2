using System.Windows.Forms;

namespace Ejercicio_sobre_listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnborrarleft_Click(object sender, EventArgs e)
        {
            if (lbSinOrdenar.SelectedItems.Count > 0)
            {
                int seleccion = lbSinOrdenar.SelectedIndex;

                if (seleccion >= 0 && seleccion < lbSinOrdenar.Items.Count)
                {
                    lbSinOrdenar.Items.RemoveAt(seleccion);
                }
            }
            else
            {
                MessageBox.Show("No seleccionaste ningun elemento para eliminar", "Cero elementos seleccionados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtLBSinOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnborrarright_Click(object sender, EventArgs e)
        {
            if(lbordenada.SelectedItems.Count > 0)
            {
                int seleccion2 = lbordenada.SelectedIndex;

                if (seleccion2 >= 0 && seleccion2 < lbordenada.Items.Count)
                {
                    lbordenada.Items.RemoveAt(seleccion2);
                }
            }
            else
            {
                MessageBox.Show("No seleccionaste ningun elemento para eliminar", "Cero elementos seleccionados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnagregarleft_Click(object sender, EventArgs e)
        {
            string entradaleft = Microsoft.VisualBasic.Interaction.InputBox("Introduzca un nuevo elemento");
            lbSinOrdenar.Items.Add(entradaleft);
        }

        private void btnborrarlistaleft_Click(object sender, EventArgs e)
        {
            DialogResult resultleft = MessageBox.Show("¿Confirmas la eliminacion de todos los elementos de la lista?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultleft == DialogResult.Yes)
            {
                lbSinOrdenar.Items.Clear();
            }
            else if (resultleft == DialogResult.No)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btntoleft_Click(object sender, EventArgs e)
        {
            //Si es menor (osea -1) es poque no se ha seleccionado nada aun

            if (lbordenada.SelectedItems.Count > 0)
            {
                //por cada item seleccionado en la listbox el la va añadir a la otra
                foreach (var itemseleccionado in lbordenada.SelectedItems)
                {
                    lbSinOrdenar.Items.Add(itemseleccionado);
                }

                //mientras los items seleccionados sean mayor a 0 va a borrarlos de el listado actual
                while (lbordenada.SelectedItems.Count > 0)
                {
                    lbordenada.Items.Remove(lbordenada.SelectedItems[0]);
                }
            }
        }

        private void btntoright_Click(object sender, EventArgs e)
        {
            //Si los items seleccionados son mayores a 0
            if (lbSinOrdenar.SelectedItems.Count > 0)
            {
                int seleccion = lbSinOrdenar.SelectedIndex;

                if (seleccion >= 0 && seleccion < lbSinOrdenar.Items.Count)
                {
                    //por cada itemseleccionado en la listbox1 el va a añadirla al listbox2
                    foreach (var itemseleccionado in lbSinOrdenar.SelectedItems)
                    {
                        lbordenada.Items.Add(itemseleccionado);
                    }

                    //mientras los items seleccionados sean mayores a 0 el va a borrarlos
                    while (lbSinOrdenar.SelectedItems.Count > 0)
                    {
                        lbSinOrdenar.Items.Remove(lbSinOrdenar.SelectedItems[0]);
                    }
                }
            }

        }

        private void btnborrarlistaright_Click(object sender, EventArgs e)
        {
            DialogResult resultright  = MessageBox.Show("¿Confirmas la eliminacion de todos los elementos de la lista?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultright == DialogResult.Yes)
            {
                lbordenada.Items.Clear();
            }
            else if (resultright == DialogResult.No)
            {

            }
        }

        private void btnagregarright_Click(object sender, EventArgs e)
        {
            string entradaright = Microsoft.VisualBasic.Interaction.InputBox("Introduzca un nuevo elemento");
            lbordenada.Items.Add(entradaright);
        }
    }
}