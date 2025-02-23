using ApiTemplate.Domain.Entities;

namespace ApiTemplate.Domain.Interfaces
{
    public interface IPagamentoRepository
    {
        Task<IEnumerable<PagamentoEntity>> ObterTodos();
        Task<PagamentoEntity> ObterPorId(Guid id);
        Task Adicionar(PagamentoEntity pagamento);
        Task Atualizar(PagamentoEntity pagamento);
        Task Deletar(Guid id);
    }
}
