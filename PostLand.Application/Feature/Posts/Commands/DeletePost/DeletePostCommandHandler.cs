using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Feature.Posts.Commands.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand>
    {
        private readonly IPostAsyncRepository _postAsyncRepository;
        private readonly IMapper mapper;

        public DeletePostCommandHandler(IPostAsyncRepository postAsyncRepository, IMapper mapper)
        {
            _postAsyncRepository = postAsyncRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _postAsyncRepository.GetByIdAsync(request.PostId);
            await _postAsyncRepository.DeleteAsync(post);
            return Unit.Value;
        }
    }
}