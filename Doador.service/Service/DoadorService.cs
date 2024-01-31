using Doador.Domain.Commands;
using Doador.Domain.Interface;

namespace Doador.service.Service
{
    public class DoadorService : IDoadorService
    {
        private readonly IDoadorRepository _repository;
        public DoadorService (IDoadorRepository repository)
        {
            _repository = repository;
        }
        public Task<IEnumerable<DoadorCommand>> GetAsync()
        {
            return _repository.GetAsync();
        }
        public Task<string> PostAsync(DoadorCommand command)
        {
            return _repository.PostAsync(command);
        }
    }
}
