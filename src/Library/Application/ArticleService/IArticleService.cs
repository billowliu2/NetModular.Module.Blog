using System;
using System.Threading.Tasks;
using NetModular.Lib.Utils.Core.Result;
using NetModular.Module.Blog.Application.ArticleService.ViewModels;
using NetModular.Module.Blog.Domain.Article.Models;

namespace NetModular.Module.Blog.Application.ArticleService
{
    /// <summary>
    /// 文章服务
    /// </summary>
    public interface IArticleService
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Query(ArticleQueryModel model);

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Add(ArticleAddModel model);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns></returns>
        Task<IResultModel> Delete(int id);

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IResultModel> Edit(int id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Update(ArticleUpdateModel model);

    }
}
