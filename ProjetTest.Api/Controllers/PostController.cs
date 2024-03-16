﻿
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectTest.Application.Features.Posts.Commands.CreatPost;
using ProjectTest.Application.Features.Posts.Commands.DeletePost;
using ProjectTest.Application.Features.Posts.Commands.UpdatePost;
using ProjectTest.Application.Features.Posts.Queries.GetPostDetail;
using ProjectTest.Application.Features.Posts.Queries.GetPostList;

namespace PostLand.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllPosts")]
        public async Task<ActionResult<List<GetPostListViewModel>>> GetAllPosts()
        {
            var dtos = await _mediator.Send(new GetPostListQuery());

         
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetPostById")]
        public async Task<ActionResult<GetPostDetailViewModel>> GetPostById(string id)
        {
            var getEventDetailQuery = new GetPostDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost(Name = "AddPost")]
        public async Task<ActionResult<string>> Create([FromBody] CreatePostCommand createPostCommand)
        {
            string id = await _mediator.Send(createPostCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdatePost")]
        public async Task<ActionResult> Update([FromBody] UpdatePostCommand updatePostCommand)
        {
            await _mediator.Send(updatePostCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeletePost")]
        public async Task<ActionResult> Delete(string id)
        {
            var deletePostCommand = new DeletePostCommand() { Id = id };
            await _mediator.Send(deletePostCommand);
            return NoContent();
        }

    }
}