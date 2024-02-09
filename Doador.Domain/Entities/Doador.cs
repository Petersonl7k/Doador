using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Entities
{
    public class Doador
    {
        public int doadorID { get; set; }
        public string nomeDoador { get; set; }
        public string estadoDoador { get; set; }
        public int idadeDoador { get; set; }
        public string doadorCEP { get; set; }
        public string bairroDoador { get; set; }
        public long telefoneDoador { get; set; }
        public string emailDoador { get; set; }
        public bool ativoDoador { get; set; }
    }
}
