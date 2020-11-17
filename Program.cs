using System;

namespace Contador_de_0_a_50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você consegue advinhar a idade desse famoso?");

            int idade;

            do
            {
                Console.WriteLine("Qual a idade dele?");
                idade = int.Parse(Console.ReadLine());
                
            }while(idade != 47);

            Console.WriteLine("Parabéns você acertou");
        }
    }
}
