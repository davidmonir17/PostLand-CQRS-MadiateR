using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Feature.Posts.Commands.DeletePost
{
    public class DeletePostCommand : IRequest
    {
        public Guid PostId { get; set; }
    }
}