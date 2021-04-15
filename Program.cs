using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9. Solicite un inggreso al usuario y lo presente en mayúscula
            CambioPorMayuscula();

            // 10. Socilite un ingreso al usuario y lo presente en minúscula
            CambioAMinuscula();
        }

        private static void CambioAMinuscula()
        {
            Console.WriteLine("Ingrese una cadena de texto");
            string minuscula = Console.ReadLine();
            Console.WriteLine($"Su ingreso fue: {minuscula}");
            Console.WriteLine($"En minúscula es: {minuscula.ToLower().ToString()}");
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }

        private static void CambioPorMayuscula()
        {
            Console.WriteLine("Ingrese una cadena de texto");
            string cadena = Console.ReadLine();

            Console.WriteLine($"Su ingreso fue: {cadena}");
            Console.WriteLine($"En mayúscula queda: {cadena.ToUpper().ToString()}");
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
