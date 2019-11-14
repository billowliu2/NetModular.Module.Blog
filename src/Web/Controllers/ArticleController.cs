using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NetModular.Lib.Utils.Core.Result;
using NetModular.Module.Blog.Application.ArticleService;
using NetModular.Module.Blog.Application.ArticleService.ViewModels;
using NetModular.Module.Blog.Domain.Article.Models;

namespace NetModular.Module.Blog.Web.Controllers
{
    [Description("文章管理")]
    public class ArticleController : ModuleController
    {
        private readonly IArticleService _service;

        public ArticleController(IArticleService service)
        {
            _service = service;
        }

        [HttpGet]
        [Description("查询")]
        public Task<IResultModel> Query([FromQuery]ArticleQueryModel model)
        {
            return _service.Query(model);
        }

        [HttpPost]
        [Description("添加")]
        public Task<IResultModel> Add(ArticleAddModel model)
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
        public Task<IResultModel> Update(ArticleUpdateModel model)
        {
            return _service.Update(model);
        }
    }
}
