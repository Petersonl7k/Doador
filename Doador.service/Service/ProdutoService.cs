using Doador.Domain.Commands;
using Doador.Domain.Interface;

namespace Doador.service.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public Task<IEnumerable<ProdutoCommand>> GetAsync()
        {
            return _repository.GetAsync();
        }
        public Task<string> PostAsync(ProdutoCommand command)
        {
            return _repository.PostAsync(command);
        }
        public Task<string> UpdateAsync(ProdutoCommand command)
        {
            return _repository.UpdateAsync(command);
        }
    }
}
