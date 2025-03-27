namespace Aplicacion_de_informe_de_ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nombreItem = txtItem.Text;

            double precioItem;

            bool precioValido = double.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el precio del articulo: "), out precioItem);

            if (!precioValido || precioItem < 0)
            {
                MessageBox.Show("Ingrese un precio válido (mayor o igual a 0).");
                return;
            }

            double ventasLunes = 0.0;
            double ventasMartes = 0.0;
            double ventasMiercoles = 0.0;
            double ventasJueves = 0.0;
            double ventasViernes = 0.0;

            if (double.TryParse(txtMonday.Text, out ventasLunes) && double.TryParse(txtTuesday.Text, out ventasMartes) && double.TryParse(txtWednesday.Text, out ventasMiercoles) && double.TryParse(txtThursday.Text, out ventasJueves) && double.TryParse(txtFriday.Text, out ventasViernes))
            {
                double ventasTotalesSemana = ventasLunes + ventasMartes + ventasMiercoles + ventasJueves + ventasViernes;
                double ingresosTotales = precioItem * ventasTotalesSemana;

                string resultado = $"Item: {nombreItem}\n" +
                          $"Precio Unitario: {precioItem:C2}\n" +
                          $"Lunes: {ventasLunes}\n" +
                          $"Martes: {ventasMartes}\n" +
                          $"Miércoles: {ventasMiercoles}\n" +
                          $"Jueves: {ventasJueves}\n" +
                          $"Viernes: {ventasViernes}\n" +
                          $"Ventas Totales de la Semana: {ventasTotalesSemana}\n" +
                          $"Ingresos Totales: {ingresosTotales:C2}";

                listView1.Items.Add(resultado);

                txtGrossSales.Text = ventasTotalesSemana.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese números válidos (del 0 al 10) en las ventas de cada día.");
            }
        }
    }
}