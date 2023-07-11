namespace MyBlog.DAL.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Text { get; set; }
        public int Likes { get; set; }
        public int DisLikes { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Tag> Tags { get; set; }

    }
}
