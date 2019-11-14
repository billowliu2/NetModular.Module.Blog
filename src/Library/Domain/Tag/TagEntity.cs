using System;
using NetModular.Lib.Data.Abstractions.Attributes;
using NetModular.Lib.Data.Core.Entities;

namespace NetModular.Module.Blog.Domain.Tag
{
    /// <summary>
    /// 标签
    /// </summary>
    [Table("Tag")]
    public partial class TagEntity : Entity<int>
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Length(100)]
        public string Name { get; set; }

        /// <summary>
        /// 文章数量
        /// </summary>
        public int Count { get; set; }

    }
}
