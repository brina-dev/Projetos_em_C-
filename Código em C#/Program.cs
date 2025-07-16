using System;

namespace Código_em_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = true;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            char genero = 'F';
            float peso = 47.45f;
            double altura = 1.65;
            string nome = "Sabrina Lima";

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(altura);
            Console.WriteLine(nome);
            Console.WriteLine(peso)  ;
            Console.WriteLine("Olá, meu nome é " + nome + "! meu peso é " + peso + "kg, minha altura é " + altura + "cm e meu sexo é " + genero + ".");
        }
    }
}
