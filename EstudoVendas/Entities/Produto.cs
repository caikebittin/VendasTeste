using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoVendas.Entities
{
    class Produto
    {
        public int Codigo { get; }
        public string Descricao { get; set; }

        private static int geradorCodigo = 100001;
        public Produto(string descricao)
        {
            Codigo = geradorCodigo;
            geradorCodigo++;
            Descricao = descricao;
        }
    }
}
