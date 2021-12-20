using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edades
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Edades;
                int PromEdad = 0;
                int AcumEdad = 0;
                int CantEdad = 0;
                for (int i = 1; i <= 20; i++)
                {
                    Console.Write("Ingrese un numero por favor: ");
                    Edades = int.Parse(Console.ReadLine());
                    if (Edades >= 18)
                    {
                        AcumEdad = AcumEdad + Edades;
                        CantEdad = CantEdad + 1;
                    }
                }
                PromEdad = AcumEdad / CantEdad;
                Console.WriteLine("El promedio de edad de las personas mayores de 18 años es :{0} años", PromEdad);
                Console.Read();
            }
            catch (Exception)
            {
                Console.WriteLine("No se puede Sacar el Promedio de personas mayores a 18 años por que no se puede dividir por cero");
                Console.Read();
            }
        }
    }
}
