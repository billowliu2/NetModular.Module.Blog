using System;
using System.ComponentModel.DataAnnotations;
using NetModular.Module.Blog.Domain.Article;

namespace NetModular.Module.Blog.Application.ArticleService.ViewModels
{
    /// <summary>
    /// 文章添加模型
    /// </summary>
    public class ArticleUpdateModel
    {
        [Required(ErrorMessage = "请选择要修改的文章")]
        public int Id { get; set; }

            /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

            /// <summary>
        /// 所属分类
        /// </summary>
        public int CategoryId { get; set; }

            /// <summary>
        /// 多媒体类型
        /// </summary>
        public MediaType MediaType { get; set; }

            /// <summary>
        /// 简介
        /// </summary>
        public string Summary { get; set; }

            /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

            /// <summary>
        /// 私有的
        /// </summary>
        public bool Private { get; set; }

            /// <summary>
        /// 已发布的
        /// </summary>
        public bool Published { get; set; }

            /// <summary>
        /// 发布日期
        /// </summary>
        public DateTime PublishedTime { get; set; }

            /// <summary>
        /// 阅读数
        /// </summary>
        public int ReadCount { get; set; }

            /// <summary>
        /// 赞数
        /// </summary>
        public int LikeCount { get; set; }

    
    }
}
