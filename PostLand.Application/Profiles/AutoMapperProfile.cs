using AutoMapper;
using ProjectTest.Application.Features.Posts.Commands.CreatPost;
using ProjectTest.Application.Features.Posts.Commands.DeletePost;
using ProjectTest.Application.Features.Posts.Commands.UpdatePost;
using ProjectTest.Application.Features.Posts.Queries.GetPostDetail;
using ProjectTest.Application.Features.Posts.Queries.GetPostList;
using ProjetTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest.Application.Profiles
{
   public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Post, GetPostListViewModel>().ReverseMap();
            CreateMap<Post, GetPostDetailViewModel>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Post, CreatePostCommand>().ReverseMap();
            CreateMap<Post, UpdatePostCommand>().ReverseMap();
            CreateMap<Post, DeletePostCommand>().ReverseMap();


        }
    }
}
