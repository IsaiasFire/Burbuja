using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MetodoBurbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, v = 0;
            int[] array;

            Console.WriteLine("posiciones del arra?");
            n = int.Parse(Console.ReadLine());

            array = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese el valor de la posicion {0}: " ,i +1);
                array[i] = int.Parse(Console.ReadLine());
            }

            //prueba de cambio
            for(int x = 1; x < n; x++)
            {
                for(int y = 0; y < n-1; y++)
                {
                    if(array[x] < array[y])
                    {
                        v = array[x];
                        array[x] = array[y];
                        array[y] = v;
                    }
                }
            }

            for(int o = 0; o < n; o++)
            {
                Console.WriteLine($"- {o}: {array[o]}");
            }

            Console.ReadKey();
        }
        
    }

}
