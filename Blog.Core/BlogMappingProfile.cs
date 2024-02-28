using Blog.Core.Models;
using AutoMapper;
using Blog.Core.Models.Dtos;
using Blog.Core.Models.Entities;

namespace Blog;

public class BlogMappingProfile : Profile
{
    public BlogMappingProfile()
    {
        CreateMap<CreatePostDto, Post>();
        CreateMap<Comment, CommentDto>();
        CreateMap<CommentDto, Comment>();
    }
}