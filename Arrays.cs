using System;

namespace arrays_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];

            for (int p = 0; p < numeros.Length; p++)
            {
                Console.WriteLine(" Digite um número maior que Zero");
                numeros[p] = Convert.ToInt32(Console.ReadLine());
            }

            for (int p = 0; p < numeros.Length; p++)
            {
                if(numeros[p] % 2 == 0)
                {
                    pares[p] = numeros[p];
                }
                else
                {
                    impares[p] = numeros[p];
                }
            }

            //Ordenar Vetores
            Array.Sort(numeros);
            Array.Sort(pares);
            Array.Sort(impares);

            Console.WriteLine("Estes são os números que você digitou:");
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("\n\nEstes são os números pares:");
            foreach (int numero in pares)
            {
                if (numero != 0) Console.WriteLine(numero);
            }

            Console.WriteLine("\n\nEstes são os números impares:");
            foreach (int numero in impares)
            {
                if (numero != 0) Console.WriteLine(numero);
            }
        }
    }
}
