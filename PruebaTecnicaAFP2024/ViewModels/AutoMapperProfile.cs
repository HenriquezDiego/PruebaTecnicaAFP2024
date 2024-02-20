using AutoMapper;
using PruebaTecnicaAFP2024.Models;

namespace PruebaTecnicaAFP2024.ViewModels
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Vehiculo, VehiculoViewModel>()
                .ForMember(src=>src.Color,opt=>opt.MapFrom(src=>src.Color.Nombre))
                .ForMember(src=>src.Marca,opt=>opt.MapFrom(src=>src.Marca.Nombre));

            CreateMap<VehiculoInput, Vehiculo>();
        }
    }
}
