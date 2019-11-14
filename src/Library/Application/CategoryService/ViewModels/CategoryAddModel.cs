using System;
using System.ComponentModel.DataAnnotations;
using NetModular.Module.Blog.Domain.Category;

namespace NetModular.Module.Blog.Application.CategoryService.ViewModels
{
    /// <summary>
    /// 分类添加模型
    /// </summary>
    public class CategoryAddModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 文章数量
        /// </summary>
        public int Count { get; set; }

    }
}
