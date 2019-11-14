using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetModular.Lib.Data.Abstractions;
using NetModular.Lib.Data.Core;
using NetModular.Lib.Data.Query;
using NetModular.Module.Admin.Domain.Account;
using NetModular.Module.Blog.Domain.Media;
using NetModular.Module.Blog.Domain.Media.Models;

namespace NetModular.Module.Blog.Infrastructure.Repositories.SqlServer
{
    public class MediaRepository : RepositoryAbstract<MediaEntity>, IMediaRepository
    {
        public MediaRepository(IDbContext context) : base(context)
        {
        }

        public async Task<IList<MediaEntity>> Query(MediaQueryModel model)
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
