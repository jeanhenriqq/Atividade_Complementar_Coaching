using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComplementar1
{
    public class Conta
    {
        public int QuantidadeMes { get; set; }
        public double ValorTotal { get; set; }
        public double Valor { get; set; }
        public double TaxaJuros { get; set; }
        public double ValorJurosMes { get; set; }



        public void CalculaRendimento()
        {
            ValorTotal = Valor;

            for (int i = 1; i <= QuantidadeMes; i++)
            {
                ValorJurosMes = ((ValorTotal * TaxaJuros) / 100);
                ValorTotal += ValorJurosMes;
            }

        }
    }
}
