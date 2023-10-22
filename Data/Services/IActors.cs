using dotnet_e_commerce.Models;

namespace dotnet_e_commerce.Data.Services
{
    public interface IActors
    {
        IEnumerable<Actor> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }

}