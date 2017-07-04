using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComplementar1
{
    class Poupanca : Conta
    {
        public double JurosPoupanca { get; set; }


        public void CalculaPoupanca()
        {
            TaxaJuros = JurosPoupanca;
            base.Calcula();
        }
    }
}
