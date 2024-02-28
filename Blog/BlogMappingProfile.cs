using Blog.Core.Models;
using Blog.Models.Dtos;
using AutoMapper;
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