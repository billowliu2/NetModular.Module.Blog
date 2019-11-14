using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetModular.Lib.Data.Abstractions;
using NetModular.Lib.Data.Core;
using NetModular.Lib.Data.Query;
using NetModular.Module.Blog.Domain.ArticleTag;
using NetModular.Module.Blog.Domain.ArticleTag.Models;

namespace NetModular.Module.Blog.Infrastructure.Repositories.SqlServer
{
    public class ArticleTagRepository : RepositoryAbstract<ArticleTagEntity>, IArticleTagRepository
    {
        public ArticleTagRepository(IDbContext context) : base(context)
        {
        }

        public async Task<IList<ArticleTagEntity>> Query(ArticleTagQueryModel model)
        {
            var paging = model.Paging();

            var query = Db.Find();

            if (!paging.OrderBy.Any())
            {
                query.OrderByDescending(m => m.Id);
            }

            var result = await query.PaginationAsync(paging);

            model.TotalCount = paging.TotalCount;

            return result;
        }
    }
}
