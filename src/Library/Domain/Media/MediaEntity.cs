using System;
using NetModular.Lib.Data.Abstractions.Attributes;
using NetModular.Lib.Data.Core.Entities.Extend;

namespace NetModular.Module.Blog.Domain.Media
{
    /// <summary>
    /// 多媒体
    /// </summary>
    [Table("Media")]
    public partial class MediaEntity : EntityBaseWithSoftDelete<int, Guid>
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
        [Length(300)]
        public string Url { get; set; }

        /// <summary>
        /// 是否外链
        /// </summary>
        public bool OutsideLink { get; set; }

        /// <summary>
        /// MD5值
        /// </summary>
		[Nullable]
        [Length(50)]
        public string MD5 { get; set; }

    }
}
