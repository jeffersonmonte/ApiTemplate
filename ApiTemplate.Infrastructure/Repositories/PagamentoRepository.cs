using ApiTemplate.Domain.Entities;
using ApiTemplate.Domain.Interfaces;
using ApiTemplate.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ApiTemplate.Infrastructure.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private readonly AppDbContext _context;

        public PagamentoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PagamentoEntity>> ObterTodos() =>
            await _context.Pagamentos.ToListAsync();

        public async Task<PagamentoEntity> ObterPorId(Guid id) =>
            await _context.Pagamentos.FindAsync(id);

        public async Task Adicionar(PagamentoEntity pagamento)
        {
            await _context.Pagamentos.AddAsync(pagamento);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(PagamentoEntity pagamento)
        {
            _context.Pagamentos.Update(pagamento);
            await _context.SaveChangesAsync();
        }

        public async Task Deletar(Guid id)
        {
            var pagamento = await ObterPorId(id);
            if (pagamento != null)
            {
                _context.Pagamentos.Remove(pagamento);
                await _context.SaveChangesAsync();
            }
        }
    }
}
