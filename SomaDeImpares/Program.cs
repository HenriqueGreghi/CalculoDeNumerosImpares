using System;

namespace SomaDeImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            Console.WriteLine("Entre com o primeiro valor :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor :");
            int y = int.Parse(Console.ReadLine());
           
            if (x < y)
            {
                for (int i = x+1; i < y; i++)
                { if (i % 2 != 0)
                    {
                        soma = soma + i;
                    }

                }
            }
            else if (x > y)
            {
                for (int i = y + 1; i < x; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma = soma + i;
                    }

                }
            }
            else
            {
                
            }
            Console.WriteLine("Resultado : " + soma);
        }
    }
}
