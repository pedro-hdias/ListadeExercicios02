using System;
using System.Collections.Generic;

namespace exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            int numero = 0;
            int resultado = 0;
            int exibirResultado = 0;
            List<int> listaNumeros = new();
            Console.WriteLine("Digite 25 números entre 0 e 10 para eu somar os quadrados dos números ímpares.");
            do
            {
                Console.WriteLine($"Digite o {contador}º número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero >= 0 && numero <= 10)
                {
                    resultado = numero % 2;
                    if (resultado == 1)
                    {
                        listaNumeros.Add(numero);
                        contador++;
                    }
                    else
                        contador++;
                }
                else
                    Console.WriteLine("Digite um número válido.");
            } while (contador <= 25);
            foreach (int lista in listaNumeros)
            {
                exibirResultado += (lista * lista);
            }
            Console.WriteLine($"O resultado da soma dos 20 números ímpares inseridos é de {exibirResultado}.");
        }
    }
}