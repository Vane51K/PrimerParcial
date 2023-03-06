using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ESCRIBE UN NUMERO ENTERO MAYOR QUE CERO: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int sumapares = 0;
            for (int i = 2; i <= N; i += 2)
            {
                sumapares += i;
            }
            Console.WriteLine("LA SUMA DE LOS ENTEROS DE {0} ES IGUAL A: {1}", N, sumapares);

            Console.WriteLine("LOS NUMEROS DIVISIBLES MAYORES O IGUALES A {0} QUE SON DIVISIBLES ENTRE 2 Y 3:", N);
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("NUMEROS ENTEROS MAYORES O IGUALES QUE {0} QUE SON DIVISIBLES ENTRE 3 Y 5:", N);
            for (int v = 1; v <= N; v++)
            {
                if (v % 3 == 0 && v % 5 == 0)
                {
                    Console.WriteLine(v);
                }
            }

            Console.WriteLine("LA SECUENCIA DE NUMEROS ENTEROS POSITIVOS COMIENZA EN {0} CULMINANDO EN EL NUMERO 1:", N);
            while (N >= 1)
            {
                Console.WriteLine(N);
                N--;
            }

            Console.WriteLine("EL VALOR DE LA VARIABLE \"sumapares\" ES: {0}", sumapares);
            Console.ReadLine();
        }
    }
}
