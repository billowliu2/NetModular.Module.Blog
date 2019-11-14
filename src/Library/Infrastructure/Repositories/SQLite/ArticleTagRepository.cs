using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.Blog.Infrastructure.Repositories.SQLite
{
    public class ArticleTagRepository : SqlServer.ArticleTagRepository
    {
        public ArticleTagRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
