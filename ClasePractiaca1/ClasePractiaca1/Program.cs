using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractiaca1
{
    internal class NotaFinal
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------------------------");
            Console.WriteLine("¿Aprobo o Desabrobo la clase?");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            string nombreEstudiante;
            double primeraNota, segundaNota, terceraNota, cuartaNota, notaFinal;

            Console.Write("Ingrese su nombre: ");
            nombreEstudiante = Console.ReadLine();
            Console.WriteLine("");

            do
            {

                Console.Write("Ingrese su primera nota: ");
                primeraNota = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

            } while (primeraNota < 0 || primeraNota > 100);  //Se utiliza OR (||), ya que debe de cumplirse cualquiera de las 2 errores,conforme a un dato guardado.

            do
            {

                Console.Write("Ingrese su segunda nota: ");
                segundaNota = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

            } while (segundaNota < 0 || segundaNota > 100);

            do
            {

                Console.Write("Ingrese su tercera nota: ");
                terceraNota = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

            } while (terceraNota < 0 || terceraNota > 100);

            do
            {

                Console.Write("Ingrese su cuarta nota: ");
                cuartaNota = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

            } while (cuartaNota < 0 || cuartaNota > 100);


            notaFinal = (primeraNota + segundaNota + terceraNota + cuartaNota) / 4;

            if (notaFinal >= 70)
            {

                Console.Write("Estudiante " + nombreEstudiante + ", usted aprobo el curso con una nota de: " + notaFinal);
                Console.WriteLine();

            }
            else
            {

                Console.Write("Estudiante " + nombreEstudiante + ", usted desabrobo el curso con una nota de: " + notaFinal);
                Console.WriteLine();

            }
               
           

        }
    }
}
