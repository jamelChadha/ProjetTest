using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest.Application.Features.Posts.Commands.DeletePost
{
    public class DeletePostCommand : IRequest<string>
    {
        public string Id { get; set; }
    }

}