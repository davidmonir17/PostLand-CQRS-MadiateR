using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Feature.Posts.Queries.GetPostDetail
{
    public class GetPostDetailQuery : IRequest<GetPostDetailDTO>
    {
        public Guid PostId { get; set; }
    }
}