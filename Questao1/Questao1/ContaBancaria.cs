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
    }
}
