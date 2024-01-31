namespace Doador.Domain.Commands
{
    public class DoadorCommand
    {
        public int doadorID { get; set; }
        public string nomeDoador {  get; set; }
        public string estadoDoador { get; set; }
        public int idadeDoador { get; set; }
        public int doadorCEP { get; set; }
        public string bairroDoador { get; set; }
        public long telefoneDoador { get; set; }
        public string emailDoador { get; set; }
        public bool ativoDoador { get; set; }
    }
}
