using _66bitPractice.Data.ViewModels;
using _66bitPractice.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _66bitPractice.Data.Services
{
    public interface IPlayerService
    {
        Task<IEnumerable<Player>> GetAllPlayers();
        Task<Player> GetPlayerById(int id);
        Task Add(NewPlayerVM player);
        Task Update(int id, NewPlayerVM newPlayer);
        Task Delete(int id);
    }
}
