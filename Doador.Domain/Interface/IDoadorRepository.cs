using Doador.Domain.Commands;

namespace Doador.Domain.Interface
{
    public interface IDoadorRepository
    {
        Task<IEnumerable<DoadorCommand>> GetAsync();
        Task<string> PostAsync(DoadorCommand command);
    }
}
