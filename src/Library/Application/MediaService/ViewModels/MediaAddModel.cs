using System;
using System.ComponentModel.DataAnnotations;
using NetModular.Module.Blog.Domain.Media;

namespace NetModular.Module.Blog.Application.MediaService.ViewModels
{
    /// <summary>
    /// 多媒体添加模型
    /// </summary>
    public class MediaAddModel
    {
        /// <summary>
        /// 文章编号
        /// </summary>
        public int ArticleId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public MediaType Type { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 是否外链
        /// </summary>
        public bool OutsideLink { get; set; }

        /// <summary>
        /// MD5值
        /// </summary>
        public string MD5 { get; set; }

    }
}
