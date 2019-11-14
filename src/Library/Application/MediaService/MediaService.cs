using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NetModular.Lib.Utils.Core.Result;
using NetModular.Module.Blog.Application.MediaService.ViewModels;
using NetModular.Module.Blog.Domain.Media;
using NetModular.Module.Blog.Domain.Media.Models;

namespace NetModular.Module.Blog.Application.MediaService
{
    public class MediaService : IMediaService
    {
        private readonly IMapper _mapper;
        private readonly IMediaRepository _repository;
        public MediaService(IMapper mapper, IMediaRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<IResultModel> Query(MediaQueryModel model)
        {
            var result = new QueryResultModel<MediaEntity>
            {
                Rows = await _repository.Query(model),
                Total = model.TotalCount
            };
            return ResultModel.Success(result);
        }

        public async Task<IResultModel> Add(MediaAddModel model)
        {
            var entity = _mapper.Map<MediaEntity>(model);
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

            var model = _mapper.Map<MediaUpdateModel>(entity);
            return ResultModel.Success(model);
        }

        public async Task<IResultModel> Update(MediaUpdateModel model)
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
