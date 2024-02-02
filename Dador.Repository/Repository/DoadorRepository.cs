using Dapper;
using Doador.Domain.Commands;
using Doador.Domain.Interface;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

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
            Values (@nomeDoador, @estadoDoador, @idadeDoador, @doadorCEP, @bairroDoador, @telefoneDoador, @emailDoador)";
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
        public async Task<string> UpdateAsync(DoadorCommand command)
        {
            string queryupdate = @"Update CadastroDoador set nomeDoador=@nomeDoador, estadoDoador=@estadoDoador, idadeDoador=@idadeDoador,
            doadorCEP=@doadorCEP, bairroDoador=@bairroDoador, telefoneDoador=@telefoneDoador, emailDoador=@emailDoador where emailDoador = @emailDoador";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryupdate, new
                {
                    nomeDoador = command.nomeDoador,
                    estadoDoador = command.estadoDoador,
                    idadeDoador = command.idadeDoador,
                    doadorCEP = command.doadorCEP,
                    bairroDoador = command.bairroDoador,
                    telefoneDoador = command.telefoneDoador,
                    emailDoador = command.emailDoador,
                });
                return "Update realiado com sucesso";
            }
        }
        public async Task<string> DeleteAsync(string email)
        {
            string querydelete = @"Update CadastroDoador set ativoDoador=@ativoDoador where emailDoador = @email";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(querydelete, new
                {
                    ativoDoador = 0,
                    email = email
                });
                return "Doador desativado com sucesso";
            }
        }



    }
}

