using AutoMapper;
using Gap.Entities.Stores;
using Gap.SuperZapatos.Models;

namespace Gap.SuperZapatos.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Store, StoreModel>();            
            CreateMap<StoreModel, Store>();

        }
    }
}