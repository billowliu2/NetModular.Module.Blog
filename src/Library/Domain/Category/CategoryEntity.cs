using System;
using NetModular.Lib.Data.Abstractions.Attributes;
using NetModular.Lib.Data.Core.Entities;

namespace NetModular.Module.Blog.Domain.Category
{
    /// <summary>
    /// 分类
    /// </summary>
    [Table("Category")]
    public partial class CategoryEntity : Entity<int>
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Length(100)]
        public string Name { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [Length(50)]
        public string Code { get; set; }

        /// <summary>
        /// 文章数量
        /// </summary>
        public int Count { get; set; }

    }
}
