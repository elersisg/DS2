using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal SalarioSemanal { get; set; }

        public Empleado(string nombre, string apellido, decimal salarioSemanal)
        {
            Nombre = nombre;
            Apellido = apellido;
            SalarioSemanal = salarioSemanal;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            // Solicitar la entrada para 10 empleados
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Introduce el empleado {i + 1}:");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Apellido: ");
                string apellido = Console.ReadLine();

                Console.Write("Salario semanal: ");
                decimal salarioSemanal = decimal.Parse(Console.ReadLine());

                // Crear un nuevo empleado
                Empleado empleado = new Empleado(nombre, apellido, salarioSemanal);

                // Agregar el empleado a la lista
                empleados.Add(empleado);
            }

            // Imprimir todos los empleados y sus salarios
            var empleadosOrdenados = from empleado in empleados
                                     orderby empleado.Apellido, empleado.Nombre
                                     select empleado;
            Console.WriteLine("\nTodos los empleados y sus salarios (ordenados por apellido y nombre):");
            foreach (var empleado in empleadosOrdenados)
            {
                Console.WriteLine($"{empleado.Nombre} {empleado.Apellido}: {empleado.SalarioSemanal}");
            }

            // Imprimir los empleados que tienen salarios entre 4,000 y 6,000
            empleadosOrdenados = from empleado in empleados
                                 where empleado.SalarioSemanal >= 4000 && empleado.SalarioSemanal <= 6000
                                 orderby empleado.Apellido, empleado.Nombre
                                 select empleado;
            Console.WriteLine("\nEmpleados con salarios entre 4,000 y 6,000 (ordenados por apellido y nombre):");
            foreach (var empleado in empleadosOrdenados)
            {
                Console.WriteLine($"{empleado.Nombre} {empleado.Apellido}: {empleado.SalarioSemanal}");
            }

            // Imprimir solo los salarios entre 4,000 y 6,000
            var salarios = from empleado in empleadosOrdenados
                           select empleado.SalarioSemanal;
            Console.WriteLine("\nSalarios entre 4,000 y 6,000:");
            foreach (var salario in salarios)
            {
                Console.WriteLine(salario);
            }

            // Mostrar solo el primer empleado de la lista anterior (First)
            var primerEmpleado = empleadosOrdenados.FirstOrDefault();
            if (primerEmpleado != null)
            {
                Console.WriteLine($"\nPrimer empleado ordenado por apellido y nombre: {primerEmpleado.Nombre} {primerEmpleado.Apellido}: {primerEmpleado.SalarioSemanal}");
            }

            // Imprimir solo los apellidos de los empleados
            empleadosOrdenados = from empleado in empleados
                                 orderby empleado.Apellido, empleado.Nombre
                                 select empleado;
            Console.WriteLine("\nApellidos de los empleados (ordenados por apellido y nombre):");
            foreach (var empleado in empleadosOrdenados)
            {
                Console.WriteLine(empleado.Apellido);
            }

            // Imprimir solo los apellidos únicos
            var apellidosUnicos = (from empleado in empleadosOrdenados
                                   select empleado.Apellido).Distinct();
            Console.WriteLine("\nApellidos únicos:");
            foreach (var apellido in apellidosUnicos)
            {
                Console.WriteLine(apellido);
            }
        }
    }


}
