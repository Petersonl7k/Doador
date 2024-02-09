namespace Doador.Domain.Commands
{
    public class ProdutoCommand
    {
        public int produtoID { get; set; }
        public string produtoNome { get; set; }
        public string descricao { get; set; }
        public string categoria { get; set; }
        public string NomeDoDoador { get; set; }
        public int QuantidadeDisponivelParaDoacao { get; set; }
    }
}
