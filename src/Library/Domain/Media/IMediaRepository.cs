using System.Collections.Generic;
using System.Threading.Tasks;
using NetModular.Lib.Data.Abstractions;
using NetModular.Lib.Data.Abstractions.Pagination;
using NetModular.Module.Blog.Domain.Media.Models;

namespace NetModular.Module.Blog.Domain.Media
{
    /// <summary>
    /// 多媒体仓储
    /// </summary>
    public interface IMediaRepository : IRepository<MediaEntity>
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IList<MediaEntity>> Query(MediaQueryModel model);
    }
}
