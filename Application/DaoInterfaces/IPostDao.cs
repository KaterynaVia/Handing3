using Models;
using Application.Logic;
using Models.DTOs;

namespace Application.DaoInterfaces;

public interface IPostDao
{
    public Task<Post> CreateAsync(Post post);
   public Task<IEnumerable<Post>> GetAsync(SearchPostParametersDto searchParams);
    Task DeleteAsync(int id);
    Task<Post?> GetByIdAsync(int id);
    Task UpdateAsync(Post post);
}