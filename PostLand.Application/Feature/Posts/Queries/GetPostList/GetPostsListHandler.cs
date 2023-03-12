using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Feature.Posts.Queries.GetPostList
{
    public class GetPostsListHandler : IRequestHandler<GetPostListQuery, List<GetPostDTO>>
    {
        private readonly IPostAsyncRepository _postAsyncRepository;
        private readonly IMapper mapper;

        public GetPostsListHandler(IPostAsyncRepository postAsyncRepository, IMapper mapper)
        {
            _postAsyncRepository = postAsyncRepository;
            this.mapper = mapper;
        }

        public async Task<List<GetPostDTO>> Handle(GetPostListQuery request, CancellationToken cancellationToken)
        {
            var allPosts = await _postAsyncRepository.GetAllPostAsync(true);
            return mapper.Map<List<GetPostDTO>>(allPosts);
        }
    }
}