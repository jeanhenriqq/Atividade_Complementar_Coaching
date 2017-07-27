using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class ItemPedido
    {
        #region properties
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int QuantidadeProduto { get; set; }
        
        #endregion
    }
}
