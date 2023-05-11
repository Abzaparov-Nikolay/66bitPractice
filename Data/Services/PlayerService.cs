using _66bitPractice.Data.HubPog;
using _66bitPractice.Data.Hubs;
using _66bitPractice.Data.ViewModels;
using _66bitPractice.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace _66bitPractice.Data.Services
{
	public class PlayerService : IPlayerService
	{
		private readonly DataBaseContext dbContext;
		private readonly IHubContext<PlayersHub, IPlayersHub> hubContext;

		//public event EventHandler<SavedChangesEventArgs> OnSaveChanges;

		public PlayerService(DataBaseContext context, IHubContext<PlayersHub,IPlayersHub> hubContext)
		{
			this.dbContext = context;
			this.hubContext = hubContext;
			dbContext.SavedChanges += OnDBChange;
		}

		public async Task Add(NewPlayerVM player)
		{
			var newPlayer = new Player()
			{
				Name = player.Name,
				Surname = player.Surname,
				BirthDate = player.BirthDate,
				TeamId = player.TeamId,
				PictureURL = player.PictureURL,
				PlayerId = player.PlayerId,
				Gender = player.Gender,
				Country = player.Country
			};
			await dbContext.Players.AddAsync(newPlayer);
			await dbContext.SaveChangesAsync();
		}

		public async Task Delete(int id)
		{
			Player player = new Player() { PlayerId = id };
			dbContext.Players.Attach(player);
			dbContext.Players.Remove(player);
			await dbContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<Player>> GetAllPlayers()
		{
			var allPlayers = await dbContext.Players.Include(player => player.Team).ToListAsync<Player>();
			return allPlayers;
		}

		public async Task<Player> GetPlayerById(int id)
		{
			var player = await dbContext.Players.Include(player => player.Team).Where(p => p.PlayerId == id).FirstOrDefaultAsync();
			return player;
		}

		public async Task Update(int id, NewPlayerVM newPlayer)
		{
			var dbPlayer = await dbContext.Players.FindAsync(id);
			if (dbPlayer != null)
			{
				dbPlayer.PictureURL = newPlayer.PictureURL;
				dbPlayer.Gender = newPlayer.Gender;
				dbPlayer.Country = newPlayer.Country;
				dbPlayer.Name = newPlayer.Name;
				dbPlayer.Surname = newPlayer.Surname;
				dbPlayer.BirthDate = newPlayer.BirthDate;
				dbPlayer.TeamId = newPlayer.TeamId;
			}
			var entry = dbContext.Entry(dbPlayer);
			entry.State = EntityState.Modified;
			await dbContext.SaveChangesAsync();
		}

		public async void OnDBChange(object sender, SavedChangesEventArgs e)
		{
			await hubContext.Clients.All.Notify();
		}
	}
}
