using _66bitPractice.Data.ViewModels;
using _66bitPractice.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _66bitPractice.Data.Services
{
	public class TeamService : ITeamService
	{
		private readonly DataBaseContext context;

		public TeamService(DataBaseContext context)
		{
			this.context = context;
		}

		public async Task Add(Team team)
		{
			context.Teams.Add(team);
			await context.SaveChangesAsync();
		}

		public async Task Add(NewTeamVM team)
		{
			if(team.Name == null)
			{
				return;
			}
			await context.Teams.AddAsync(new Team() { Name= team.Name });
			await context.SaveChangesAsync();
		}

		public async Task Delete(int id)
		{
			context.Teams.Remove(await context.Teams.FindAsync(id));
			await context.SaveChangesAsync();
		}

		public async Task<IEnumerable<Team>> GetAllTeams()
		{
			return await context.Teams.Include(team => team.Players).ToListAsync();
		}

		public async Task<Team> GetTeamById(int id)
		{
			return await context.Teams.FindAsync(id);
		}
	}
}
