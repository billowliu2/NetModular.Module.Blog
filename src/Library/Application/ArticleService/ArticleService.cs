using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NetModular.Lib.Utils.Core.Result;
using NetModular.Module.Blog.Application.ArticleService.ViewModels;
using NetModular.Module.Blog.Domain.Article;
using NetModular.Module.Blog.Domain.Article.Models;

namespace NetModular.Module.Blog.Application.ArticleService
{
    public class ArticleService : IArticleService
    {
        private readonly IMapper _mapper;
        private readonly IArticleRepository _repository;
        public ArticleService(IMapper mapper, IArticleRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<IResultModel> Query(ArticleQueryModel model)
        {
            var result = new QueryResultModel<ArticleEntity>
            {
                Rows = await _repository.Query(model),
                Total = model.TotalCount
            };
            return ResultModel.Success(result);
        }

        public async Task<IResultModel> Add(ArticleAddModel model)
        {
            var entity = _mapper.Map<ArticleEntity>(model);
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

            var model = _mapper.Map<ArticleUpdateModel>(entity);
            return ResultModel.Success(model);
        }

        public async Task<IResultModel> Update(ArticleUpdateModel model)
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
