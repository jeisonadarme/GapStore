using AutoMapper;
using Gap.Entities.Articles;
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

            CreateMap<Article, ArticleModel>().ForMember(dest => dest.StoreName, opt => opt.MapFrom(x => x.Store.Name));
            CreateMap<Article, ArticleModel>().ForMember(dest => dest.StoreAddress, opt => opt.MapFrom(x => x.Store.Address));

            CreateMap<ArticleModel, Article>();
        }
    }
}