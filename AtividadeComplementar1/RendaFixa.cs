using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComplementar1
{
    public class RendaFixa : Conta
    {
        public double ValorComImposto { get; set; }

        public void CalculaRendaFixa()
        {
            base.CalculaRendimento();
            CalculaImposto();
        }

        public void CalculaImposto()
        {

            if (QuantidadeMes <= 12)
            {
                ValorComImposto = ValorTotal - (ValorJurosMes * 0.25);
            }
            else if (QuantidadeMes <= 24)
            {
                ValorComImposto = ValorTotal - (ValorJurosMes * 0.15);
            }
            else if (QuantidadeMes <= 36)
            {
                ValorComImposto = ValorTotal - (ValorJurosMes * 0.05);
            }
            else
            {
                ValorComImposto = ValorTotal - (ValorJurosMes * 0.01);
            }
        }
    }
}
