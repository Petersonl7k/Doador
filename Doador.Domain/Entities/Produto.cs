using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Entities
{
    public class Produto
    {
        public int produtoID { get; set; }
        public string produtoNome { get; set; }
        public string descricao { get; set; }
        public string categoria { get; set; }
        public string NomeDoDoador { get; set; }
        public int QuantidadeDisponivelParaDoacao { get; set; }
    }
}
