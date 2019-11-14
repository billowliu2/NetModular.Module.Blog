using System.Collections.Generic;
using System.Threading.Tasks;
using NetModular.Lib.Data.Abstractions;
using NetModular.Lib.Data.Abstractions.Pagination;
using NetModular.Module.Blog.Domain.ArticleTag.Models;

namespace NetModular.Module.Blog.Domain.ArticleTag
{
    /// <summary>
    /// 文章标签列表仓储
    /// </summary>
    public interface IArticleTagRepository : IRepository<ArticleTagEntity>
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IList<ArticleTagEntity>> Query(ArticleTagQueryModel model);
    }
}
