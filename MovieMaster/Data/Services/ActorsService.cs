using Microsoft.EntityFrameworkCore;
using MovieMaster.Models;

namespace MovieMaster.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly DataContext _context;
        public ActorsService(DataContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetActorsAsync()
        {
            var actors = await _context.Actors.ToListAsync();
            return actors;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
