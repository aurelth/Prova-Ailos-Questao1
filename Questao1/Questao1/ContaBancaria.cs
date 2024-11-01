using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    public class ContaBancaria
    {
        public int NumeroConta { get; }
        public string NomeTitular { get; private set; }

        private double Saldo;

        private const double TaxaSaque = 3.50;

        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial = 0.0)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = depositoInicial;
        }

        public void AlterarNomeTitular(string novoNome)
        {
            NomeTitular = novoNome;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0)
            {
                Saldo -= valor + TaxaSaque;
            }
            else
            {
                Console.WriteLine("O valor do saque deve ser positivo.");
            }
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {NomeTitular}, Saldo: $ {Saldo:F2}";
        }
    }
}
