using System;

namespace ProjetTest.Domain
{
    public class Post
    {
       
        public string Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public Category Category { get; set; }
        public string CategoryId { get; set; }
    }
}
