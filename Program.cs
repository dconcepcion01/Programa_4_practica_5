using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_4_practica_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //areglo que el usuario elige la dimension
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("ESTE PROGRAMA TE PERMITE ELEGIR LA DIMENCION DEL AREGLO");

            int[] n;
            int cantidad=0;
            Console.WriteLine("Ingrese el tamaño del areglo");
            cantidad = int.Parse(Console.ReadLine());

            n = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el numero");
                n[i] = int.Parse(Console.ReadLine());


            }
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Los numeros ingresados son :  " + n[i] );

            }
            Console.ReadLine();

        }
    }
}
