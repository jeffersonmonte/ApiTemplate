using ApiTemplate.Application.DTOs;
using ApiTemplate.Application.Interfaces;
using ApiTemplate.Domain.Entities;
using ApiTemplate.Domain.Interfaces;
using AutoMapper;

namespace ApiTemplate.Application.Services
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IPagamentoRepository _pagamentoRepository;
        private readonly IMapper _mapper;

        public PagamentoService(IPagamentoRepository pagamentoRepository, IMapper mapper)
        {
            _pagamentoRepository = pagamentoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PagamentoDTO>> ObterTodos()
        {
            var pagamentos = await _pagamentoRepository.ObterTodos();
            return _mapper.Map<IEnumerable<PagamentoDTO>>(pagamentos);
        }

        public async Task<PagamentoDTO> ObterPorId(Guid id)
        {
            var pagamento = await _pagamentoRepository.ObterPorId(id);
            return _mapper.Map<PagamentoDTO>(pagamento);
        }

        public async Task Adicionar(PagamentoDTO pagamentoDto)
        {
            var pagamento = _mapper.Map<PagamentoEntity>(pagamentoDto);
            await _pagamentoRepository.Adicionar(pagamento);
        }

        public async Task Atualizar(PagamentoDTO pagamentoDto)
        {
            var pagamento = _mapper.Map<PagamentoEntity>(pagamentoDto);
            await _pagamentoRepository.Atualizar(pagamento);
        }

        public async Task Deletar(Guid id)
        {
            await _pagamentoRepository.Deletar(id);
        }
    }
}
