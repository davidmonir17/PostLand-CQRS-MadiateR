using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Feature.Posts.Queries.GetPostList
{
    public class GetPostDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImageURl { get; set; }
        public string Content { get; set; }
        public CtegoryDTO Category { get; set; }
    }
}