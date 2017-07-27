using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Produto
    {
        #region properties
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtFabricacao { get; set; }
        public DateTime DtValidacao { get; set; }
        public Categoria Categoria { get; set; }
        public int QuantidadeEstoque { get; set; }
        public float Valor { get; set; }


        #endregion

        #region methods
        public void VerificarEstoque()
        {

        }

        #endregion

    }
}
