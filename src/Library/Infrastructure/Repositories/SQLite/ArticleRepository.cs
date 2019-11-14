using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.Blog.Infrastructure.Repositories.SQLite
{
    public class ArticleRepository : SqlServer.ArticleRepository
    {
        public ArticleRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
