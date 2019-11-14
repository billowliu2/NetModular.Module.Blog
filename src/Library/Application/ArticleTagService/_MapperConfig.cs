using AutoMapper;
using NetModular.Lib.Mapper.AutoMapper;
using NetModular.Module.Blog.Application.ArticleTagService.ViewModels;
using NetModular.Module.Blog.Domain.ArticleTag;

namespace NetModular.Module.Blog.Application.ArticleTagService
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<ArticleTagAddModel, ArticleTagEntity>();
            cfg.CreateMap<ArticleTagEntity, ArticleTagUpdateModel>();
            cfg.CreateMap<ArticleTagUpdateModel, ArticleTagEntity>();
        }
    }
}
