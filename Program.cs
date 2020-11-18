using System;

namespace Exemplos_Trabalho_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Exemplo6 e6 = new Exemplo6("Gustavo", "Barnasque");
            Console.WriteLine(e6.ToString());
            Console.WriteLine("Hello World!");

            Exemplo7 e7 = new Exemplo7();
            int? x = e7.StringToInt("123");
            if (x != null)
                Console.WriteLine(x);
            else
                Console.WriteLine("deu ruim");

            e7.ShowGameScore();


            Exemplo8 e8 = new Exemplo8();
            e8.CreatePoint();
            e8.ShowNewIndexAndRange();

            Exemplo9 e9 = new();
            Console.WriteLine(e9.IsLetter('a'));
        }
    }
}
