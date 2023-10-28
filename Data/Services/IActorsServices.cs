using dotnet_e_commerce.Models;

namespace dotnet_e_commerce.Data.Services
{
    public interface IActorsServices
    {
        Task<IEnumerable<Actor>> GetAll();
        Task<Actor?> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        void Delete(int id);
    }
}