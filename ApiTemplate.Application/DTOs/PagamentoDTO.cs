namespace ApiTemplate.Application.DTOs
{
    public class PagamentoDTO
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public string MetodoPagamento { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
