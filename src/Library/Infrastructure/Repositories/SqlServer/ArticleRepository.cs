using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetModular.Lib.Data.Abstractions;
using NetModular.Lib.Data.Core;
using NetModular.Lib.Data.Query;
using NetModular.Module.Admin.Domain.Account;
using NetModular.Module.Blog.Domain.Article;
using NetModular.Module.Blog.Domain.Article.Models;

namespace NetModular.Module.Blog.Infrastructure.Repositories.SqlServer
{
    public class ArticleRepository : RepositoryAbstract<ArticleEntity>, IArticleRepository
    {
        public ArticleRepository(IDbContext context) : base(context)
        {
        }

        public async Task<IList<ArticleEntity>> Query(ArticleQueryModel model)
        {
            var paging = model.Paging();

            var query = Db.Find();

			var joinQuery = query.LeftJoin<AccountEntity>((x, y) => x.CreatedBy == y.Id);
			if (!paging.OrderBy.Any())
            {
                joinQuery.OrderByDescending((x, y) => x.Id);
            }
			joinQuery.Select((x, y) => new { x, Creator = y.Name });

            var result = await joinQuery.PaginationAsync(paging);

            model.TotalCount = paging.TotalCount;

            return result;
        }
    }
}
