using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComplementar1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            Conta conta = new Conta();
            Poupanca poupanca = new Poupanca();
            RendaFixa rendaFixa = new RendaFixa();
            #endregion


            Console.Write("Valor a ser aplicado:  ");
            conta.Valor = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nTaxa de juros de poupança: ");
            poupanca.JurosPoupanca = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nTaxa de juros de Renda Fixa: ");
            rendaFixa.TaxaJuros = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nMeses de aplicação: ");
            conta.QuantidadeMes = Convert.ToInt32(Console.ReadLine());

            rendaFixa.PreencherConta(conta);
            poupanca.PreencherConta(conta);

            poupanca.CalculaPoupanca();
            rendaFixa.CalculaRendaFixa();

            #region Print Result    
            Console.WriteLine("\n_____________________________________________________________________________________\n");
            Console.WriteLine("Valor total da Poupanca: R$ {0 : 0.##}", poupanca.ValorTotal);
            Console.WriteLine("Valor total da Renda Fixa sem o desconto do IR: R$ {0: 0.##}", rendaFixa.ValorTotal);
            Console.WriteLine("Valor total da Renda Fixa com o desconto do IR: R$ {0: 0.##}", rendaFixa.ValorComImposto);
            Console.WriteLine("\n_____________________________________________________________________________________\n");

            if (poupanca.ValorTotal > rendaFixa.ValorComImposto)
            {
                Console.WriteLine("Nesse caso, seria indicada a aplicação em Poupança, por ter um retorno melhor.");
            }
            else if (poupanca.ValorTotal < rendaFixa.ValorComImposto)
            {
                Console.WriteLine("Nesse caso, seria indicada a aplicação em Renda Fixa, por ter um retorno melhor.");
            }
            else
            {
                Console.WriteLine("Os dois tipos de aplicação terão o mesmo retorno.");
            }
            #endregion            

            Console.ReadKey();
        }
    }
}
