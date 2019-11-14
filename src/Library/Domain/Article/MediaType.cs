using System.ComponentModel;

namespace NetModular.Module.Blog.Domain.Article
{
    /// <summary>
    /// 多媒体类型
    /// </summary>
    public enum MediaType
    {
        [Description("图片")]
        Picture = 0,
        [Description("视频")]
        Video = 1,
        [Description("音乐")]
        Music = 2
    }
}
