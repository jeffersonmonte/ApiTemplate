using ApiTemplate.Application.DTOs;
using ApiTemplate.Domain.Entities;
using AutoMapper;

namespace ApiTemplate.Application.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PagamentoDTO, PagamentoEntity>().ReverseMap();
        }
    }
}
