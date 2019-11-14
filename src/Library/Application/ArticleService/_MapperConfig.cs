using AutoMapper;
using NetModular.Lib.Mapper.AutoMapper;
using NetModular.Module.Blog.Application.ArticleService.ViewModels;
using NetModular.Module.Blog.Domain.Article;

namespace NetModular.Module.Blog.Application.ArticleService
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<ArticleAddModel, ArticleEntity>();
            cfg.CreateMap<ArticleEntity, ArticleUpdateModel>();
            cfg.CreateMap<ArticleUpdateModel, ArticleEntity>();
        }
    }
}
