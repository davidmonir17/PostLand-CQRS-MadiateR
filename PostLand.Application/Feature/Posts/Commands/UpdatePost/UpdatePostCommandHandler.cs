using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using PostLand.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Feature.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand>
    {
        private readonly IPostAsyncRepository _postAsyncRepository;
        private readonly IMapper mapper;

        public UpdatePostCommandHandler(IPostAsyncRepository postAsyncRepository, IMapper mapper)
        {
            _postAsyncRepository = postAsyncRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            var post = mapper.Map<Post>(request);
            await _postAsyncRepository.UpdateAsync(post);
            return Unit.Value;
        }
    }
}