using System.Diagnostics;
using System.IO.Packaging;

namespace Shippinghub
{
    public partial class Form1 : Form
    {
        private List<Package> packages = new List<Package>();
        private int currentIndex = -1;
        private bool isEditing = false;
        public Form1()
        {
            InitializeComponent();
            InitializeControls();

        }

        private void InitializeControls()
        {
            string[] estados = { "AL", "FL", "GA", "KY", "MS", "NC", "SC", "TN", "WV", "VA" };
            cmbstate.Items.AddRange(estados);
            cmbpackagesbystate.Items.AddRange(estados);

            HabilitarBotones(false);


        }
        private void HabilitarBotones(bool accesible)
        {
            btnback.Enabled = accesible;
            btnadd.Enabled = accesible;
            btnEdit.Enabled = accesible;
            btnnext.Enabled = accesible;
            btnremove.Enabled = accesible;
            cmbpackagesbystate.Enabled = accesible;
            cmbstate.Enabled = accesible;
            txtaddress.Enabled = accesible;
            txtarrivedat.Enabled = accesible;
            txtcity.Enabled = accesible;
            txtpackageID.Enabled = accesible;
            txtzip.Enabled = accesible;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtzip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtzip.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnscannew_Click(object sender, EventArgs e)
        {
            txtarrivedat.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtpackageID.Text = GenerarIDPaquete().ToString();
            cmbstate.SelectedIndex = -1;

            txtzip.Clear();
            txtcity.Clear();
            txtaddress.Clear();

            HabilitarBotones(true);
        }

        private int GenerarIDPaquete()
        {
            Random random = new Random();
            return random.Next(10000000, 99999999);
        }


        private void ActualizarListBox() //Constructor para actualizar la lista de los pedidos
        {
            lstPackages.Items.Clear();
            foreach (var package in packages)
            {
                lstPackages.Items.Add(package.PackageNumber.ToString());
            }
        }

        public class Package //Constructor para establecer los datos que componen un paquete
        {
            public required string Address { get; set; }
            public required string City { get; set; }

            public required string State { get; set; }

            public required int Zip { get; set; }

            public required int PackageNumber { get; set; }

            public DateTime ArrivalDate { get; set; }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string estado = cmbstate.SelectedItem.ToString();

            if (string.IsNullOrEmpty(estado))
            {
                MessageBox.Show("Select an state");
                return;
            }

            var newPackage = new Package
            {
                ArrivalDate = DateTime.Parse(txtarrivedat.Text),
                PackageNumber = int.Parse(txtpackageID.Text),

                State = estado,
                Address = txtaddress.Text,
                City = txtcity.Text,
                Zip = int.Parse(txtzip.Text)
            };
            packages.Add(newPackage);

            ActualizarListBox();

            txtzip.Enabled = false;
            txtcity.Enabled = false;
            txtaddress.Enabled = false;
            cmbstate.Enabled = false;

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (lstPackages.SelectedIndex != -1)
            {
                int selectedIndex = lstPackages.SelectedIndex;
                packages.RemoveAt(selectedIndex);
                lstPackages.Items.RemoveAt(selectedIndex);
            }

            txtaddress.Clear();
            txtarrivedat.Clear();
            txtcity.Clear();
            txtpackageID.Clear();
            txtzip.Clear();
            cmbstate.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Funciones necesarias para cambiar el texto del boton Edit a Update

            if (lstPackages.SelectedIndex != -1)
            {
                if (btnEdit.Text == "Edit")
                {
                    txtzip.Enabled = true;
                    txtcity.Enabled = true;
                    txtaddress.Enabled = true;
                    cmbstate.Enabled = true;

                    btnEdit.Text = "Update";

                    btnadd.Enabled = false;
                    btnback.Enabled = false;
                    btnnext.Enabled = false;
                    btnremove.Enabled = false;
                    btnscannew.Enabled = false;

                }
                else if (btnEdit.Text == "Update")
                {
                    Package selectedpackage = packages[lstPackages.SelectedIndex];

                    selectedpackage.Address = txtaddress.Text;
                    selectedpackage.City = txtcity.Text;
                    selectedpackage.State = cmbstate.SelectedItem.ToString();
                    selectedpackage.Zip = int.Parse(txtzip.Text);

                    txtzip.Enabled = false;
                    txtcity.Enabled = false;
                    txtaddress.Enabled = false;
                    cmbstate.Enabled = false;

                    btnEdit.Text = "Edit";

                    btnadd.Enabled = true;
                    btnback.Enabled = true;
                    btnnext.Enabled = true;
                    btnremove.Enabled = true;
                    btnscannew.Enabled = true;


                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {  //Para actualizar el indice en lstPackages 
                currentIndex--;
                DisplayPackage(packages[currentIndex]);
                lstPackages.SelectedIndex = currentIndex;
            }
        }

        private void DisplayPackage(Package package)
        {
            if (package != null)
            {
                txtarrivedat.Text = package.ArrivalDate.ToString("dd/MM/yyyy HH:mm:ss");
                txtpackageID.Text = package.PackageNumber.ToString();
                txtaddress.Text = package.Address;
                txtcity.Text = package.City;
                txtzip.Text = package.Zip.ToString();
                cmbstate.Text = package.State;

            }
        }

        private void lstPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPackages.SelectedIndex != -1 && packages.Count > 0)
            {
                currentIndex = lstPackages.SelectedIndex;
                var selectedPackage = packages[currentIndex];
                DisplayPackage(selectedPackage);
            }
        }

        private void cmbpackagesbystate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = cmbpackagesbystate.SelectedItem.ToString();
            var filteredPackages = packages.Where(p => p.State == selectedState).ToList();
            lstPackages.Items.Clear();

            foreach (var package in filteredPackages)
            {
                lstPackages.Items.Add(package.PackageNumber.ToString());
            }
        }

        private void txtcity_TextChanged(object sender, KeyPressEventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {  //Para actualizar el indice en lstPackages 
                currentIndex++;
                DisplayPackage(packages[currentIndex]);
                lstPackages.SelectedIndex = currentIndex;
            }
        }
    }
}