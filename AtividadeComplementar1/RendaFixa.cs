using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComplementar1
{
    class RendaFixa : Conta
    {
        public double ValorComImposto { get; set; }

        public void CalculaRendaFixa()
        {
            base.Calcula();
            CalculaImposto();
        }

        public void CalculaImposto()
        {
            var imposto = ValorTotal - Valor;

            if (QuantidadeMes <= 12)
            {
                ValorComImposto = ValorTotal - (imposto * 0.25);
            }
            else if (QuantidadeMes <= 24)
            {
                ValorComImposto = ValorTotal - (imposto * 0.15);
            }
            else if (QuantidadeMes <= 36)
            {
                ValorComImposto = ValorTotal - (imposto * 0.05);
            }
            else
            {
                ValorComImposto = ValorTotal - (imposto * 0.01);
            }
        }
    }
}
