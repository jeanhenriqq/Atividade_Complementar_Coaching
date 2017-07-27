using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Fornecedor
    {
        #region properties 

        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public IList ListaFornecedor { get; set; }

        #endregion

        #region methods



        #endregion
    }
}
