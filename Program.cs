using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(false);
        }
        static void Menu(bool error)
        {
            Console.Clear();

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Boas vindas à calculadora básica desenvolvida pelo Patrick Mendes Silva!");
            Console.WriteLine("Abaixo as operações disponíveis na versão atual:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-----------------------------------------------------");

            if(error)
                Console.WriteLine("Selecione uma operação válida!");
            else
                Console.WriteLine("Qual operação deseja realizar?");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(true); break;
            }
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultadoSoma = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultadoSoma}");

            Console.ReadKey(); 
            Menu(false);               
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultadoSubtracao = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultadoSubtracao}");
            Console.ReadKey();   

            Menu(false);     
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultadoDivisao = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultadoDivisao}");
            Console.ReadKey(); 

            Menu(false);               
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultadoMultiplicacao = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultadoMultiplicacao}");
            Console.ReadKey();

            Menu(false);               
        }
    }
}