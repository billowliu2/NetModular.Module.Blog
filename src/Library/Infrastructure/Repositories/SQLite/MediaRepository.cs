using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.Blog.Infrastructure.Repositories.SQLite
{
    public class MediaRepository : SqlServer.MediaRepository
    {
        public MediaRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
