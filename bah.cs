using System;

class Program
{
    // Função principal do programa
    static void Main()
    {
        Console.WriteLine("Calculadora Simples");
        Console.WriteLine("====================");

        // Solicita ao usuário o primeiro número
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Solicita ao usuário o segundo número
        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Solicita ao usuário a operação desejada
        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.Write("Digite o número da operação desejada: ");
        int operacao = Convert.ToInt32(Console.ReadLine());

        // Calcula o resultado com base na operação escolhida
        double resultado = 0;
        switch (operacao)
        {
            case 1:
                resultado = Soma(num1, num2);
                break;
            case 2:
                resultado = Subtracao(num1, num2);
                break;
            case 3:
                resultado = Multiplicacao(num1, num2);
                break;
            case 4:
                // Verifica se o divisor é zero para evitar divisão por zero
                if (num2 != 0)
                {
                    resultado = Divisao(num1, num2);
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    return; // Encerra o programa se houver erro
                }
                break;
            default:
                Console.WriteLine("Operação inválida.");
                return; // Encerra o programa se a operação for inválida
        }

        // Exibe o resultado
        Console.WriteLine($"O resultado da operação é: {resultado}");
    }

    // Função para soma
    static double Soma(double a, double b)
    {
        return a + b;
    }

    // Função para subtração
    static double Subtracao(double a, double b)
    {
        return a - b;
    }

    // Função para multiplicação
    static double Multiplicacao(double a, double b)
    {
        return a * b;
    }

    // Função para divisão
    static double Divisao(double a, double b)
    {
        return a / b;
    }
}
