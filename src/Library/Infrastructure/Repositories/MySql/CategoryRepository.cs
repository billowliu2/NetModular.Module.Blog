using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.Blog.Infrastructure.Repositories.MySql
{
    public class CategoryRepository : SqlServer.CategoryRepository
    {
        public CategoryRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}