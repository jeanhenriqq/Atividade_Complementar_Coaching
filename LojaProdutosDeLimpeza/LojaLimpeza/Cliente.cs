using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Cliente
    {
        #region
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Contato Contato { get; set; }
        public Endereco Endereco { get; set; }
        public IList ListaCliente { get; set; }

        #endregion 

    }
}
