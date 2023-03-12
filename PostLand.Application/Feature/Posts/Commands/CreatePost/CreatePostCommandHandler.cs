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

namespace PostLand.Application.Feature.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Guid>
    {
        private readonly IPostAsyncRepository _postAsyncRepository;
        private readonly IMapper mapper;

        public CreatePostCommandHandler(IPostAsyncRepository postAsyncRepository, IMapper mapper)
        {
            _postAsyncRepository = postAsyncRepository;
            this.mapper = mapper;
        }

        public async Task<Guid> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = mapper.Map<Post>(request);
            CreateCommandValidator validations = new CreateCommandValidator();
            var result = await validations.ValidateAsync(request);
            if (result.Errors.Any())
            {
                throw new Exception("Post is not valid");
            }

            post = await _postAsyncRepository.AddAsync(post);
            return post.Id;
        }
    }
}