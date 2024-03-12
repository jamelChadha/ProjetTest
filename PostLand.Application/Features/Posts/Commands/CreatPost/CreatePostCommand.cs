using MediatR;
using ProjectTest.Application.Features.Posts.Queries.GetPostList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest.Application.Features.Posts.Commands.CreatPost
{
    public class CreatePostCommand : IRequest<string>
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public string CategoryId { get; set; }

    }
}
