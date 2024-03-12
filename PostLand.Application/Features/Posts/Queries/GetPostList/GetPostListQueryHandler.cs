using AutoMapper;
using MediatR;
using System.Collections.Generic;
using ProjectTest.Application.Contracts.Persistence;
using ProjectTest.Application.Features.Posts.Queries.GetPostList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest.Application.Features.Posts.Queries.GetPostList
{
    public class GetPostListQueryHandler : IRequestHandler<GetPostListQuery, List<GetPostListViewModel>>
  
 {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public GetPostListQueryHandler (IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
    public async Task<List<GetPostListViewModel>> Handle (GetPostListQuery request, CancellationToken cancelation )
    {
        var allPosts=await _postRepository.GetAllPostsAsync(true);
        return _mapper.Map<List<GetPostListViewModel>>(allPosts);
    }

       
    }
}
