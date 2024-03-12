namespace ProjetTest.Domain
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Blogs { get; set; }
    }
}
