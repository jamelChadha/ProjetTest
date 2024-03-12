
using ProjetTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest.Application.Contracts.Persistence
{
    public interface IPostRepository : IAsyncRepository<Post>
    {
        Task<IReadOnlyList<Post>> GetAllPostsAsync(bool includeCategory);
        Task<Post> GetPostByIdAsync(string id, bool includeCategory);
    }
}
