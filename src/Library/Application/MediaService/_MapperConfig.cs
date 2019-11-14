using AutoMapper;
using NetModular.Lib.Mapper.AutoMapper;
using NetModular.Module.Blog.Application.MediaService.ViewModels;
using NetModular.Module.Blog.Domain.Media;

namespace NetModular.Module.Blog.Application.MediaService
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<MediaAddModel, MediaEntity>();
            cfg.CreateMap<MediaEntity, MediaUpdateModel>();
            cfg.CreateMap<MediaUpdateModel, MediaEntity>();
        }
    }
}
