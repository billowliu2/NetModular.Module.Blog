using System.Collections.Generic;
using System.Threading.Tasks;
using NetModular.Lib.Data.Abstractions;
using NetModular.Lib.Data.Abstractions.Pagination;
using NetModular.Module.Blog.Domain.Article.Models;

namespace NetModular.Module.Blog.Domain.Article
{
    /// <summary>
    /// 文章仓储
    /// </summary>
    public interface IArticleRepository : IRepository<ArticleEntity>
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IList<ArticleEntity>> Query(ArticleQueryModel model);
    }
}
