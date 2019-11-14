using System;
using NetModular.Lib.Data.Abstractions.Attributes;
using NetModular.Lib.Data.Core.Entities;

namespace NetModular.Module.Blog.Domain.ArticleTag
{
    /// <summary>
    /// 文章标签列表
    /// </summary>
    [Table("Article_Tag")]
    public partial class ArticleTagEntity : Entity<int>
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
