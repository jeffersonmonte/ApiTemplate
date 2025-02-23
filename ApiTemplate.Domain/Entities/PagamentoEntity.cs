namespace ApiTemplate.Domain.Entities
{
    public class PagamentoEntity
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public string MetodoPagamento { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
