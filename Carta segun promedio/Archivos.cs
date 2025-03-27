using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Carta_segun_promedio
{
    class Archivos
    {
        static void Main(String[] args)
        {
            string carpetaDestino = @"\CartaPromedio\";

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Ingrese el nombre y el apellido del estudiante {i}:");
                string nombreApellido = Console.ReadLine();

                Console.WriteLine($"Ingrese el promedio del estudiante{i}:");
                double promedio;
                if(double.TryParse(Console.ReadLine(), out promedio) )
                {
                    string resultado = (promedio >= 70) ? "Aprobado" : "Reprobado";

                    //Para formatear el nombre para usarlo como nombre de archivo 

                    string nombreArchivo = Path.Combine(carpetaDestino, nombreApellido.Replace(" ", "").ToLower() + ".txt");

                    //Para crear el archivo con File.Create y escribir el mensaje de acuerdo al promedio
                    using (StreamWriter wr = File.CreateText(nombreArchivo))
                    {
                        if (promedio > 70)
                        {
                            wr.WriteLine($"Estimad@ {nombreApellido}, queremos felicitarle por pasar exitosamente de curso y aprobar todas sus asignaturas.");

                        }
                        else
                        {
                            wr.WriteLine($"Estimad@ {nombreApellido}, lamentamos informarle que ha sido reprobado con un promedio de {promedio}.");
                        }
                    }

                    Console.WriteLine($"Se ha generado el archivo {nombreArchivo}");
                }
                else
                {
                    Console.WriteLine("Entrada no valida. Intenta nuevamente");
                    i--; //Se le resta al contador para repetir la entrada del estudiante. 
                }
            }

            EliminarArchivosGenerados(carpetaDestino);

            Console.WriteLine("Todos los archivos generados han sido eliminados");

        }
        //Metodo para que elimine los archivos de la carpeta en cuanto termine de ejecutar el programa 
        static void EliminarArchivosGenerados (string carpeta)
        {
            string[] archivos = Directory.GetFiles(carpeta);

            foreach (string archivo in archivos)
            {
                File.Delete(archivo);
            }
        }
    }
}