namespace Miniblog.Core
{
    public class BlogSettings
    {
        public string Owner { get; set; } = "Jordi AG";
        public int PostsPerPage { get; set; } = 2;
        public int CommentsCloseAfterDays { get; set; } = 10;
        public string Description { get; set; } = "";
    }
}
