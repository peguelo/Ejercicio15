using System;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int mensualidad = 0, total = 0;
            Console.WriteLine("Pagar mensualmente el producto");
            while (i <= 20)
            {
                if(i == 1)
                {
                    mensualidad = 10;
                }
                else
                {
                    mensualidad = mensualidad * 2;
                }
                Console.WriteLine("El pago en el mes {0} es ${1}", i, mensualidad);
                total = total + mensualidad;
                i++;
            }
            Console.WriteLine("\nEl pago total es: ${0}", total);
            Console.ReadKey();
        }
    }
}
