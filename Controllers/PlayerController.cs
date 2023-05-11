using _66bitPractice.Data.HubPog;
using _66bitPractice.Data.Services;
using _66bitPractice.Data.Utils;
using _66bitPractice.Data.ViewModels;
using _66bitPractice.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _66bitPractice.Controllers
{
	public class PlayerController : Controller
	{
		private readonly IPlayerService playerService;
		private readonly ITeamService teamService;

		public PlayerController(IPlayerService playerService, ITeamService teamService)
		{
			this.playerService = playerService;
			this.teamService = teamService;
		}

		public async Task<IActionResult> Show()
		{
			var modelData = (await playerService.GetAllPlayers()).Select(p => new PlayerVM(p));
			await UpdateViewBagData();
			return View(modelData);
		}

		public async Task<IActionResult> Edit(int id)
		{
			var player = await playerService.GetPlayerById(id);
			if (player == null)
			{
				return View("NotFound");
			}
			await UpdateViewBagData();
			return View(new NewPlayerVM(player));
		}

		[HttpPost]
		public async Task<IActionResult> Update(int id, NewPlayerVM player)
		{
			if (!ModelState.IsValid)
			{
				return View(player);
			}
			await playerService.Update(id, player);
			return RedirectToAction(nameof(Show));
		}

		[HttpPost]
		public async Task<IActionResult> AddNew(NewPlayerVM player)
		{
			if (!ModelState.IsValid)
			{
				await UpdateViewBagData();
				return View("Add", player);
			}
			await playerService.Add(player);
			return RedirectToAction(nameof(Show));
		}

		public async Task<IActionResult> Add()
		{
			await UpdateViewBagData();
			return View();
		}

		public async Task<IActionResult> Delete(int id)
		{
			await playerService.Delete(id);
			await UpdateViewBagData();
			return RedirectToAction(nameof(Show));
		}


		public async Task<IActionResult> Search(string searchString)
		{
			var allPlayers = await playerService.GetAllPlayers();

			if (!string.IsNullOrEmpty(searchString))
			{
				var filteredResultNew = allPlayers.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase)
				|| string.Equals(n.Surname, searchString, StringComparison.CurrentCultureIgnoreCase))
					.Select(p => new PlayerVM(p))
					.ToList();

				return View("Show", filteredResultNew);
			}
			return View("NotFound");
		}

		[HttpGet]
		public IEnumerable<int> GetPlayersIds()
		{
			return (playerService.GetAllPlayers().Result).Select(p => p.PlayerId);
		}

		[HttpGet]
		public ActionResult GetPlayerPartialById(int id)
		{
			return PartialView("_PlayerTemplatePV", new PlayerVM(playerService.GetPlayerById(id).Result));
		}

		private async Task UpdateViewBagData()
		{
			ViewBag.Teams = await teamService.GetAllTeams();
		}
	}
}
