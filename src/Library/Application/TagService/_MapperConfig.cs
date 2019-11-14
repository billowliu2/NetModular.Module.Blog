using AutoMapper;
using NetModular.Lib.Mapper.AutoMapper;
using NetModular.Module.Blog.Application.TagService.ViewModels;
using NetModular.Module.Blog.Domain.Tag;

namespace NetModular.Module.Blog.Application.TagService
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TagAddModel, TagEntity>();
            cfg.CreateMap<TagEntity, TagUpdateModel>();
            cfg.CreateMap<TagUpdateModel, TagEntity>();
        }
    }
}
