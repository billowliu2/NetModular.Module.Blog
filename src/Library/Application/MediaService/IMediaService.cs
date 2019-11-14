using System;
using System.Threading.Tasks;
using NetModular.Lib.Utils.Core.Result;
using NetModular.Module.Blog.Application.MediaService.ViewModels;
using NetModular.Module.Blog.Domain.Media.Models;

namespace NetModular.Module.Blog.Application.MediaService
{
    /// <summary>
    /// 多媒体服务
    /// </summary>
    public interface IMediaService
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Query(MediaQueryModel model);

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Add(MediaAddModel model);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns></returns>
        Task<IResultModel> Delete(int id);

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IResultModel> Edit(int id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Update(MediaUpdateModel model);

    }
}
