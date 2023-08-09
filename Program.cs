using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuarLoop = true;

            while (continuarLoop)
            {

                Console.Clear();
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("DIGITE A OPERAÇÃO QUE DESEJA REALIZAR\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair\n");
                int escolha = int.Parse(Console.ReadLine());

                Console.Clear();

                if (escolha == 5)
                {
                    continuarLoop = false;
                    break;
                }
                else if (escolha > 5)
                {
                    Console.WriteLine("\nOpção Invalida");
                    continuarLoop = false;
                    break;
                }
                else
                {
                    Menu(escolha);
                }
            }
        }

        static void Soma(float numero1, float numero2)
        {
            float soma = numero1 + numero2;
            string resultado = $"\nA soma dos valores é {soma}";
            Console.WriteLine(resultado);
        }

        static void Subtracao(float numero1, float numero2)
        {
            float subtracao = numero1 - numero2;
            string resultado = $"\nA subtração dos valores é {subtracao}";
            Console.WriteLine(resultado);
        }

        static void Multiplicacao(float numero1, float numero2)
        {
            float multiplicacao = numero1 * numero2;
            string resultado = $"\nA multiplicação dos valores é {multiplicacao}";
            Console.WriteLine(resultado);
        }

        static void Divisao(float numero1, float numero2)
        {
            float divisao = numero1 / numero2;
            string resultado = $"\nA divisão dos valores é {divisao}";
            Console.WriteLine(resultado);
        }

        static void Menu(int escolha)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.Clear();
            switch (escolha)
            {
                case 1:
                    Soma(valor1, valor2);
                    break;
                case 2:
                    Subtracao(valor1, valor2);
                    break;
                case 3:
                    Multiplicacao(valor1, valor2);
                    break;
                case 4:
                    Divisao(valor1, valor2);
                    break;
            }

            Console.WriteLine("\nTecle `ENTER` para continuar...\n");
            Console.ReadKey();
        }
    }

}