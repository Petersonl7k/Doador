using Dapper;
using Doador.Domain.Commands;
using Doador.Domain.Interface;
using System.Data.SqlClient;

namespace Doador.Repository.Repository
{
    public class DoadorRepository : IDoadorRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<IEnumerable<DoadorCommand>> GetAsync()
        {
            string querygetDoador = @"Select * From CadastroDoador where ativoDoador = 1";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                return await conn.QueryAsync<DoadorCommand>(querygetDoador);

            }

        }
        public async Task<string> PostAsync(DoadorCommand command)
        {
            string queryinsert = @"Insert Into CadastroDoador(nomeDoador, estadoDoador, idadeDoador, doadorCEP, bairroDoador, telefoneDoador, emailDoador)
            Values (@nomeDoador, @estadoDoador, @bairroDoador, @telefoneDoador, @emailDoador)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryinsert, new
                {
                    nomeDoador = command.nomeDoador,
                    estadoDoador = command.estadoDoador,
                    idadeDoador = command.idadeDoador,
                    doadorCEP = command.doadorCEP,
                    bairroDoador = command.bairroDoador,
                    telefoneDoador = command.telefoneDoador,
                    emailDoador = command.emailDoador,
                });
                return "Doador cadastrado com sucesso";
            }
        }
    

    }
}

