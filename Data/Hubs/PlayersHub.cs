using _66bitPractice.Data.Hubs;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace _66bitPractice.Data.HubPog
{
	public class PlayersHub : Hub<IPlayersHub>
    {
		public async Task Notify()
		{
			await Clients.All.Notify();
		}
	}
}
