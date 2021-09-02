using System;

namespace sobrenome
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenome;
            Console.WriteLine("Qual o seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine("Qual o seu sobrenome? ");
            sobrenome = Console.ReadLine();

            Console.WriteLine($"{nome} {sobrenome}");
            Console.WriteLine($"{sobrenome.ToUpper()}, {nome}");
        }
    }
}
