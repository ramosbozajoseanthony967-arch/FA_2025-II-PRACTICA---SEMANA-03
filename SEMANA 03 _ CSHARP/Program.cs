using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_03___CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio1();
            Console.ReadKey();
        }
        static void ejercicio1()
        {
            string nombre, carrera; //declarando variables
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido a FA de {carrera}");


        }

        static void ejercicio2()
        {
            Console.Write("Ingrese numero x: ");
            int x = int .Parse( Console.ReadLine() );
            Console.Write("Ingrese numero y: ");
            int y = int.Parse(Console.ReadLine());
            double resu = (double) x / (double)y;

            Console.WriteLine("suma: "+(x+y));
            Console.WriteLine("resta: " + (x - y));
            Console.WriteLine("multiplicacion: " + (x * y));
            Console.WriteLine("division: " + resu);
            Console.ReadKey();

        }
     

        static void ejercicio3()
        {

        }

        static void ejercicio4()
        {

        }
        static void ejercicio5()

        {

        }
        static void ejercicio6()
        {

        }
    }
}
