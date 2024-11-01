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
    }
}
