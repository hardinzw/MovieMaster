using MovieMaster.Models;

namespace MovieMaster.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetActorsAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        Task DeleteAsync(int id);
    }
}
