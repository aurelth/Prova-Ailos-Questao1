using Questao1;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

bool cadastrarNovaConta;

do
{
    Console.Write("Entre o número da conta: ");
    int numeroConta = int.Parse(Console.ReadLine());

    Console.Write("Entre o titular da conta: ");
    string nomeTitular = Console.ReadLine();

    Console.Write("Haverá depósito inicial (s/n)? ");
    char depositoInicialResposta = char.Parse(Console.ReadLine().ToLower());

    double depositoInicial = 0;
    if (depositoInicialResposta == 's')
    {
        Console.Write("Entre o valor de depósito inicial: ");
        depositoInicial = double.Parse(Console.ReadLine());
    }

    var conta = new ContaBancaria(numeroConta, nomeTitular, depositoInicial);

    Console.WriteLine("\nDados da conta:");
    Console.WriteLine(conta);

    Console.Write("\nEntre um valor para depósito: ");
    double valorDeposito = double.Parse(Console.ReadLine());
    conta.Depositar(valorDeposito);

    Console.WriteLine("\nDados da conta atualizados:");
    Console.WriteLine(conta);

    Console.Write("\nEntre um valor para saque: ");
    double valorSaque = double.Parse(Console.ReadLine());
    conta.Sacar(valorSaque);

    Console.WriteLine("\nDados da conta atualizados:");
    Console.WriteLine(conta);

    Console.Write("\nDeseja cadastrar mais alguma conta? (s/n): ");
    cadastrarNovaConta = Console.ReadLine().ToLower() == "s";

} while (cadastrarNovaConta);

Console.WriteLine("Operação finalizada. Obrigado!");
