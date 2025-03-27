using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavanderia
{
     class Factura
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-/- GeorgeTown Cleaning Services -/-");
            Console.WriteLine();

            Console.Write("Nombre del cliente: ");
            string nombreCliente = Console.ReadLine();

            Console.Write("Teléfono del cliente: ");
            string telefonoCliente = Console.ReadLine();

            DateTime fechaActual = DateTime.Now;

            Console.Write("Número de camisas: ");
            int numCamisas = int.Parse(Console.ReadLine());

            Console.Write("Número de pantalones: ");
            int numPantalones = int.Parse(Console.ReadLine());

            Console.Write("Número de vestidos: ");
            int numVestidos = int.Parse(Console.ReadLine());

            double precioCamisas = 0.35;
            double precioPantalones = 0.75;
            double precioVestidos = 4.25;

            double totalCamisas = numCamisas * precioCamisas;
            double totalPantalones = numPantalones * precioPantalones;
            double totalVestidos = numVestidos * precioVestidos;

            double totalVentas = totalCamisas + totalPantalones + totalVestidos;

            // Se muestra la factura 

            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" -/- GeorgeTown Cleaning Services");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Customer name: " + nombreCliente);
            Console.WriteLine("Customer Phone: " + telefonoCliente);
            Console.WriteLine("Order date: " + fechaActual);
            Console.WriteLine("Item / Qty / u/Price / Total");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"Camisas\t{numCamisas}\t\t${precioCamisas}\t\t${totalCamisas}");
            Console.WriteLine($"Pantalones\t{numPantalones}\t\t${precioPantalones}\t\t${totalPantalones}");
            Console.WriteLine($"Vestidos\t{numVestidos}\t\t${precioVestidos}\t\t${totalVestidos}");
            Console.WriteLine("---------------------------------------------------------------");

            double tax = 0.18; //Impuesto del 18%
            double subtotal = totalVentas;
            double totalTax = subtotal * tax;
            double netprice = subtotal + tax;

            // Mostrar los totales
            Console.WriteLine($"Subtotal:\t\t${subtotal}");
            Console.WriteLine($"Tax ({tax * 100}%):\t\t${totalTax}");
            Console.WriteLine($"Total:\t\t\t${netprice}");


            // Pedir el monto a pagar
            Console.WriteLine("--------------------------------");
            Console.Write("Introduzca el monto a pagar: ");
            double montoPago = double.Parse(Console.ReadLine());

            // Calcular y mostrar la diferencia o el cambio
            double diferencia = montoPago - netprice;
            Console.WriteLine($"Pago:\t\t\t${montoPago}");
            Console.WriteLine($"Diferencia:\t\t${diferencia}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Gracias por su compra. ¡Vuelva pronto!");

            Console.ReadLine();
        }
    }
}
