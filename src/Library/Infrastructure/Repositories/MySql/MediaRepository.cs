using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.Blog.Infrastructure.Repositories.MySql
{
    public class MediaRepository : SqlServer.MediaRepository
    {
        public MediaRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}