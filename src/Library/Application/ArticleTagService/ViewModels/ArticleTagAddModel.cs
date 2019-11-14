using System;
using System.ComponentModel.DataAnnotations;
using NetModular.Module.Blog.Domain.ArticleTag;

namespace NetModular.Module.Blog.Application.ArticleTagService.ViewModels
{
    /// <summary>
    /// 文章标签列表添加模型
    /// </summary>
    public class ArticleTagAddModel
    {
        /// <summary>
        /// 文章编号
        /// </summary>
        public int ArticleId { get; set; }

        /// <summary>
        /// 标签编号
        /// </summary>
        public int TagId { get; set; }

    }
}
