using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Categoria
    {
        #region properties
        public int Id { get; set; }
        public string Categoria { get; set; }
        public IList ListaDeCategoria { get; set; }

        #endregion
    }
}
