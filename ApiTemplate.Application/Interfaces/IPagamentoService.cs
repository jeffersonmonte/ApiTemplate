using ApiTemplate.Application.DTOs;

namespace ApiTemplate.Application.Interfaces
{
    public interface IPagamentoService
    {
        Task<IEnumerable<PagamentoDTO>> ObterTodos();
        Task<PagamentoDTO> ObterPorId(Guid id);
        Task Adicionar(PagamentoDTO pagamentoDto);
        Task Atualizar(PagamentoDTO pagamentoDto);
        Task Deletar(Guid id);
    }
}
