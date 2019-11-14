using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NetModular.Lib.Utils.Core.Result;
using NetModular.Module.Blog.Application.ArticleTagService.ViewModels;
using NetModular.Module.Blog.Domain.ArticleTag;
using NetModular.Module.Blog.Domain.ArticleTag.Models;

namespace NetModular.Module.Blog.Application.ArticleTagService
{
    public class ArticleTagService : IArticleTagService
    {
        private readonly IMapper _mapper;
        private readonly IArticleTagRepository _repository;
        public ArticleTagService(IMapper mapper, IArticleTagRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<IResultModel> Query(ArticleTagQueryModel model)
        {
            var result = new QueryResultModel<ArticleTagEntity>
            {
                Rows = await _repository.Query(model),
                Total = model.TotalCount
            };
            return ResultModel.Success(result);
        }

        public async Task<IResultModel> Add(ArticleTagAddModel model)
        {
            var entity = _mapper.Map<ArticleTagEntity>(model);
            //if (await _repository.Exists(entity))
            //{
                //return ResultModel.HasExists;
            //}

            var result = await _repository.AddAsync(entity);
            return ResultModel.Result(result);
        }

        public async Task<IResultModel> Delete(int id)
        {
            var result = await _repository.DeleteAsync(id);
            return ResultModel.Result(result);
        }

        public async Task<IResultModel> Edit(int id)
        {
            var entity = await _repository.GetAsync(id);
            if (entity == null)
                return ResultModel.NotExists;

            var model = _mapper.Map<ArticleTagUpdateModel>(entity);
            return ResultModel.Success(model);
        }

        public async Task<IResultModel> Update(ArticleTagUpdateModel model)
        {
            var entity = await _repository.GetAsync(model.Id);
            if (entity == null)
                return ResultModel.NotExists;

            _mapper.Map(model, entity);

            //if (await _repository.Exists(entity))
            //{
                //return ResultModel.HasExists;
            //}

            var result = await _repository.UpdateAsync(entity);

            return ResultModel.Result(result);
        }
    }
}
