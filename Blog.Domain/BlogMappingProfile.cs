using Blog.Domain.Models;
using AutoMapper;
using Blog.Domain.Models.Dtos;
using Blog.Domain.Models.Entities;

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