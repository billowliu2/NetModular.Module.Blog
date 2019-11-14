using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.Blog.Infrastructure.Repositories.SQLite
{
    public class CategoryRepository : SqlServer.CategoryRepository
    {
        public CategoryRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
