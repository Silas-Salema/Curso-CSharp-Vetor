using System;

namespace Exercicio_Fixação_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] vetor = new Quarto[10];
            Console.Write("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());
            

            for(int i = 1 ; i <= n ; i++)
            {
                Console.WriteLine("Aluguel #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Quarto { Nome = nome, Email = email };
            }

            Console.WriteLine("Quartos ocupados: ");
            for ( int i = 0; i<10; i++)
            {
                if(vetor[i] != null)
                {
                    Console.WriteLine(i + ": " + vetor[i].Nome + ", " + vetor[i].Email);
                }
            }
        }
    }
}
