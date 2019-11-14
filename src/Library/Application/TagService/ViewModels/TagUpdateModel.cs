using System;
using System.ComponentModel.DataAnnotations;
using NetModular.Module.Blog.Domain.Tag;

namespace NetModular.Module.Blog.Application.TagService.ViewModels
{
    /// <summary>
    /// 标签添加模型
    /// </summary>
    public class TagUpdateModel
    {
        [Required(ErrorMessage = "请选择要修改的标签")]
        public int Id { get; set; }

            /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

            /// <summary>
        /// 文章数量
        /// </summary>
        public int Count { get; set; }

    
    }
}
