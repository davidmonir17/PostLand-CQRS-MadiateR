using AutoMapper;
using PostLand.Application.Feature.Posts.Commands.CreatePost;
using PostLand.Application.Feature.Posts.Commands.DeletePost;
using PostLand.Application.Feature.Posts.Commands.UpdatePost;
using PostLand.Application.Feature.Posts.Queries.GetPostDetail;
using PostLand.Application.Feature.Posts.Queries.GetPostList;
using PostLand.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, GetPostDTO>().ReverseMap();

            CreateMap<Post, GetPostDetailDTO>().ReverseMap();
            CreateMap<Category, CtegoryDTO>().ReverseMap();
            CreateMap<Post, CreatePostCommand>().ReverseMap();
            CreateMap<Post, UpdatePostCommand>().ReverseMap();
            CreateMap<Post, DeletePostCommand>().ReverseMap();
        }
    }
}