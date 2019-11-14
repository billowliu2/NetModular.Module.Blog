using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NetModular.Lib.Utils.Core.Result;
using NetModular.Module.Blog.Application.MediaService;
using NetModular.Module.Blog.Application.MediaService.ViewModels;
using NetModular.Module.Blog.Domain.Media.Models;

namespace NetModular.Module.Blog.Web.Controllers
{
    [Description("多媒体管理")]
    public class MediaController : ModuleController
    {
        private readonly IMediaService _service;

        public MediaController(IMediaService service)
        {
            _service = service;
        }

        [HttpGet]
        [Description("查询")]
        public Task<IResultModel> Query([FromQuery]MediaQueryModel model)
        {
            return _service.Query(model);
        }

        [HttpPost]
        [Description("添加")]
        public Task<IResultModel> Add(MediaAddModel model)
        {
            return _service.Add(model);
        }

        [HttpDelete]
        [Description("删除")]
        public Task<IResultModel> Delete([BindRequired]int id)
        {
            return _service.Delete(id);
        }

        [HttpGet]
        [Description("编辑")]
        public Task<IResultModel> Edit([BindRequired]int id)
        {
            return _service.Edit(id);
        }

        [HttpPost]
        [Description("修改")]
        public Task<IResultModel> Update(MediaUpdateModel model)
        {
            return _service.Update(model);
        }
    }
}
