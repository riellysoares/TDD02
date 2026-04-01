using System;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new Cliente();
        ContaBancaria conta = new ContaBancaria();
        AnalisadorCredito analisador = new AnalisadorCredito();

        Console.Write("Digite o nome do cliente: ");
        cliente.Nome = Console.ReadLine();

        Console.Write("Digite o estado (UF): ");
        cliente.EstadoUF = Console.ReadLine();

        Console.Write("Digite o saldo da conta: ");
        conta.Saldo = decimal.Parse(Console.ReadLine());

        conta.Titular = cliente;

        int scoreFinal = analisador.Calcular(conta);

        Console.WriteLine();
        Console.WriteLine("===== RESULTADO =====");
        Console.WriteLine("Cliente: " + cliente.Nome);
        Console.WriteLine("Estado: " + cliente.EstadoUF.ToUpper());
        Console.WriteLine("Saldo: R$ " + conta.Saldo);
        Console.WriteLine("Score final: " + scoreFinal);

        Console.ReadKey();
    }
}