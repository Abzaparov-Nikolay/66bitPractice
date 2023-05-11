using _66bitPractice.Data.ViewModels;
using _66bitPractice.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _66bitPractice.Data.Services
{
	public interface ITeamService
	{
		Task<IEnumerable<Team>> GetAllTeams();
		Task<Team> GetTeamById(int id);
		Task Add(Team team);
		Task Add(NewTeamVM team);
		Task Delete(int id);
	}
}
