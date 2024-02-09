using Doador.Domain.Commands;

namespace Doador.Domain.Interface
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<ProdutoCommand>> GetAsync();
        Task<string> PostAsync(ProdutoCommand command);
        Task<string> UpdateAsync(ProdutoCommand command);
    }
}
