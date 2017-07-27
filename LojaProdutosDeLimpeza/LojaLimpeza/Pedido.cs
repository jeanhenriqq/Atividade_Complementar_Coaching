using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Pedido
    {
        #region properties
        public int Id { get; set; }
        public DateTime DtPedido { get; set; }
        public IList ListaItemPedido { get; set; }
        public IList ListaDePedido { get; set; }
        public Cliente Cliente { get; set; }


        #endregion
    }
}
