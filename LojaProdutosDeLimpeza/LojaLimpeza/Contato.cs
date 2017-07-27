using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Contato
    {
        #region properties
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public IList ListaTelefone { get; set; }
        
        #endregion
    }
}
