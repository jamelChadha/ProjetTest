using AutoMapper;
using MediatR;
using ProjectTest.Application.Contracts.Persistence;
using ProjectTest.Application.Features.Posts.Commands.CreatPost;
using ProjetTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest.Application.Features.Posts.Commands.CreatPost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand,string>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public CreatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        //public async Task<string> Handle (CreatePostCommand request , CancellationToken cancellationToken)
        //{
        //    Post post = _mapper.Map<Post>(request);
        //    CreatCommandValidators validators = new CreatCommandValidators();
        //    var result = await validators.ValidateAsync(request);
        //    if (result.Errors.Any())
        //    {
        //        throw new Exception("Post is not valid ");
        //    }
        //    post = await _postRepository.AddAsync(post);
        //    return post.Id;
        //}
        public async Task<string> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            Post post = _mapper.Map<Post>(request);
            post.Id = Guid.NewGuid().ToString(); // Générer un nouvel ID unique
            CreatCommandValidators validators = new CreatCommandValidators();
            var result = await validators.ValidateAsync(request);
            if (result.Errors.Any())
            {
                throw new Exception("Post is not valid ");
            }
            post = await _postRepository.AddAsync(post);
            return post.Id;
        }
    }
}


