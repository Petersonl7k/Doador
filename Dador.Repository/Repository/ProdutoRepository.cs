using Dapper;
using Doador.Domain.Commands;
using Doador.Domain.Interface;
using System.Data.SqlClient;

namespace Doador.Repository.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<IEnumerable<ProdutoCommand>> GetAsync()
        {
            string querygetProduto = @"Select * From ProdutoDoador where QuantidadeDisponiveParaDoacao = 1";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                return await conn.QueryAsync<ProdutoCommand>(querygetProduto);  

            }

        }
        public async Task<string> PostAsync(ProdutoCommand command)
        {
            string queryinsert = @"Insert Into ProdutoDoador(produtoNome, descricao, categoria, NomeDoDoador, QuantidadeDisponivelParaDoacao)
            Values (@produtoNome, @descricao, @categoria, @NomeDoDoador, @QuantidadeDisponivelParaDoacao)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryinsert, new
                {
                    produtoNome = command.produtoNome,
                    descricao = command.descricao,
                    categoria = command.categoria,
                    NomeDoDoador = command.NomeDoDoador,
                    QuantidadeDisponivelParaDoacao = command.QuantidadeDisponivelParaDoacao,
                });
                return "Produto cadastrado com sucesso";
            }
        }
        public async Task<string> UpdateAsync(ProdutoCommand command)
        {
            string queryupdate = @"Update ProdutoDoador set produtoNome=@produtoNome, descricao=@descricao, categoria=@categoria,
            NomeDoDoador=@NomeDoDoador, QuantidadeDisponivelParaDoacao=@QuantidadeDisponivelParaDoacao)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryupdate, new
                {
                    produtoNome = command.produtoNome,
                    descricao = command.descricao,
                    categoria = command.categoria,
                    NomeDoDoador = command.NomeDoDoador,
                    QuantidadeDisponivelParaDoacao = command.QuantidadeDisponivelParaDoacao,
                });
                return "Update realizado com sucesso";
            }
        }
    }
}
