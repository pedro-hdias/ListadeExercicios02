using System;

namespace exercicio01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            int maior18 = 0;
            Console.WriteLine("Vou contar quantas pessoas tem mais de 18 anos. Insira 10 idades.");
            do
            {
                Console.WriteLine("Digite a idade:");
                int idade = Convert.ToInt32(Console.ReadLine());
                if (idade >= 18)
                {
                    maior18 += 1;
                    contador++;
                }
                else
                {
                    contador++;
                }
            } while (contador <= 10);
            Console.WriteLine($"Existem {maior18} pessoas que tem as idades acima dos 18 anos.");
        }
    }
}