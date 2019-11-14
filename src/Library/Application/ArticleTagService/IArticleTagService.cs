using System;
using System.Threading.Tasks;
using NetModular.Lib.Utils.Core.Result;
using NetModular.Module.Blog.Application.ArticleTagService.ViewModels;
using NetModular.Module.Blog.Domain.ArticleTag.Models;

namespace NetModular.Module.Blog.Application.ArticleTagService
{
    /// <summary>
    /// 文章标签列表服务
    /// </summary>
    public interface IArticleTagService
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Query(ArticleTagQueryModel model);

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Add(ArticleTagAddModel model);

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
        Task<IResultModel> Update(ArticleTagUpdateModel model);

    }
}
