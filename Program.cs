using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuario! Qual é o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome);
            Console.WriteLine("e seu sobrenome?");
            string sobrenome = Console.ReadLine();

            Console.Write("nome completo: ");
            Console.WriteLine(nome + " " + sobrenome);
            Console.Write("Nome catálogado: ");
            Console.WriteLine($"{sobrenome.ToUpper()}" + ", "+ nome);        
        }
    }
}
