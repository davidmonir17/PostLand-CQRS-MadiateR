using Microsoft.EntityFrameworkCore;
using PostLand.Application.Contracts;
using PostLand.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Presistance.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostAsyncRepository
    {
        public PostRepository(PostDbContext postDbContext) : base(postDbContext)
        {
        }

        public async Task<IReadOnlyList<Post>> GetAllPostAsync(bool includeCategory)
        {
            List<Post> allPosts = new List<Post>();
            allPosts = includeCategory ? await _dbContext.Posts.Include(x => x.Category).ToListAsync() : await _dbContext.Posts.ToListAsync();
            return allPosts;
        }

        public async Task<Post> GetPostByIdAsync(Guid id, bool includeCategory)
        {
            Post Post = new Post();
            Post = includeCategory ? await _dbContext.Posts.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id) : await GetByIdAsync(id);
            return Post;
        }
    }
}