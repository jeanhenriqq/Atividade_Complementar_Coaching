using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComplementar1
{
    public class Poupanca : Conta
    {
        public void CalculaPoupanca()
        {
            base.CalculaRendimento();
        }
    }
}
