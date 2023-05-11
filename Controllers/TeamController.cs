using _66bitPractice.Data.Services;
using _66bitPractice.Data.ViewModels;
using _66bitPractice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace _66bitPractice.Controllers
{
	public class TeamController : Controller
	{
		private readonly ITeamService service;

		public TeamController(ITeamService service)
		{
			this.service = service;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddNewTeam(NewTeamVM team)
		{
			await service.Add(team);
			return RedirectToAction("Add", "Player");
		}

		[HttpGet]
		public IActionResult GetTeamFormPV()
		{
			return PartialView("_TeamFormValuesPV");
		}
	}
}
