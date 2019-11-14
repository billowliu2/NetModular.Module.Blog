using System;
using NetModular.Lib.Data.Abstractions.Attributes;
using NetModular.Lib.Data.Core.Entities.Extend;

namespace NetModular.Module.Blog.Domain.Article
{
    /// <summary>
    /// 文章
    /// </summary>
    [Table("Article")]
    public partial class ArticleEntity : EntityBase<int>
    {
        /// <summary>
        /// 标题
        /// </summary>
        [Length(200)]
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
        [Length(500)]
        public string Summary { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
		[Max]
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
