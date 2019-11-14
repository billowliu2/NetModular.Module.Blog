using AutoMapper;
using NetModular.Lib.Mapper.AutoMapper;
using NetModular.Module.Blog.Application.CategoryService.ViewModels;
using NetModular.Module.Blog.Domain.Category;

namespace NetModular.Module.Blog.Application.CategoryService
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<CategoryAddModel, CategoryEntity>();
            cfg.CreateMap<CategoryEntity, CategoryUpdateModel>();
            cfg.CreateMap<CategoryUpdateModel, CategoryEntity>();
        }
    }
}
