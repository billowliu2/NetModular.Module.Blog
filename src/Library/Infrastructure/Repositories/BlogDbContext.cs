using System;
using NetModular.Lib.Data.Abstractions;
using NetModular.Lib.Data.Core;

namespace NetModular.Module.Blog.Infrastructure.Repositories
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(IDbContextOptions options, IServiceProvider serviceProvider) : base(options, serviceProvider)
        {
        }
    }
}
