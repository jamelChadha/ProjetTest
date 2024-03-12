using AutoMapper;
using MediatR;
using ProjectTest.Application.Contracts.Persistence;
using ProjectTest.Application.Features.Posts.Queries.GetPostList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest.Application.Features.Posts.Queries.GetPostDetail
{
    public class GetPostDetailQueryHandler : IRequestHandler<GetPostDetailQuery,GetPostDetailViewModel>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public GetPostDetailQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<GetPostDetailViewModel> Handle(GetPostDetailQuery request, CancellationToken cancelationToken)
        {
            var Post = await _postRepository.GetPostByIdAsync(request.Id,true);
            return _mapper.Map<GetPostDetailViewModel>(Post);
        }


    }
}
