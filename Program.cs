using System;

namespace Separadorint
{
    class Program
    {


        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Hey Master");
            Console.WriteLine("1- Entrar Na Aplicação ");
            Console.WriteLine("0 - Sair ");
            Console.WriteLine("************************");
            short options = short.Parse(Console.ReadLine());
            switch (options)
            {
                case 1: Aplicaticao(); break;
                case 0: System.Environment.Exit(0); break;
            }
        }

        static void Aplicaticao()
        {
            Console.Clear();
            Console.WriteLine("Insira o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro valor:");
            int valor3 = int.Parse(Console.ReadLine());

            int A = valor1;
            int B = valor2;
            int C = valor3;

            int[] D = { A, B, C };
            Array.Reverse(D);
            Array.Sort(D);
            Console.Clear();

            Console.Write("O maior numero é " + D[2] + " ");
            Console.WriteLine(" ");
            foreach (int V in D)
            {

                Console.WriteLine(V + " ");

            }


        }
    }
}
