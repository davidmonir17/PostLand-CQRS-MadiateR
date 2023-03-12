using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Feature.Posts.Queries.GetPostDetail
{
    public class GetPostDetailQueryHandler : IRequestHandler<GetPostDetailQuery, GetPostDetailDTO>
    {
        private readonly IPostAsyncRepository _postAsyncRepository;
        private readonly IMapper mapper;

        public GetPostDetailQueryHandler(IPostAsyncRepository postAsyncRepository, IMapper mapper)
        {
            _postAsyncRepository = postAsyncRepository;
            this.mapper = mapper;
        }

        public async Task<GetPostDetailDTO> Handle(GetPostDetailQuery request, CancellationToken cancellationToken)
        {
            var Post = await _postAsyncRepository.GetPostByIdAsync(request.PostId, true);
            return mapper.Map<GetPostDetailDTO>(Post);
        }
    }
}