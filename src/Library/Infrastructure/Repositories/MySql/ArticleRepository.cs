using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.Blog.Infrastructure.Repositories.MySql
{
    public class ArticleRepository : SqlServer.ArticleRepository
    {
        public ArticleRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}