using Doador.Domain.Commands;

namespace Doador.Domain.Interface
{
    public interface IDoadorRepository
    {
        Task<IEnumerable<DoadorCommand>> GetAsync();
        Task<string> PostAsync(DoadorCommand command);
        Task<string> UpdateAsync(DoadorCommand command);
        Task<string> DeleteAsync(string email);
    }
}
