using PostLand.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Contracts
{
    public interface IPostAsyncRepository : IAsyncRepository<Post>
    {
        Task<IReadOnlyList<Post>> GetAllPostAsync(bool includeCategory);

        Task<Post> GetPostByIdAsync(Guid id, bool includeCategory);
    }
}