using _66bitPractice.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace _66bitPractice.Data
{
	public class DataBaseInitializer
	{
		public static void Init(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<DataBaseContext>();

				context.Database.EnsureCreated();

				if (!context.Teams.Any())
				{
					context.Teams.AddRange(new List<Team>()
					{
						new Team() { Name = "Team1" },
						new Team() { Name = "Team2" },
						new Team() { Name = "Team3" }
					});
					context.SaveChanges();
				}
				if (!context.Players.Any())
				{
					context.Players.AddRange(new List<Player>()
					{
						new Player()
						{
							//PlayerId = 0,
							PictureURL = "https://dotnethow.net/images/actors/actor-1.jpeg",
							Name = "Mike",
							Surname = "Claritos",
							Gender = Gender.Male,
							BirthDate = new System.DateTime(2000, 3, 20),
							Team = context.Teams.FirstOrDefault(),
							Country = Country.USA
						},
						new Player()
						{
							//PlayerId = 0,
							PictureURL = "https://dotnethow.net/images/actors/actor-2.jpeg",
							Name = "Paul",
							Surname = "Poggerino",
							Gender = Gender.Male,
							BirthDate = new System.DateTime(2001, 4, 21),
							Team = context.Teams.FirstOrDefault(),
							Country = Country.Italy
						},
						new Player()
						{
							//PlayerId = 0,
							PictureURL = "https://dotnethow.net/images/actors/actor-3.jpeg",
							Name = "Melan",
							Surname = "Chiropino",
							Gender = Gender.Female,
							BirthDate = new System.DateTime(2002, 2, 19),
							Team = context.Teams.FirstOrDefault(),
							Country = Country.Italy
						},
						new Player()
						{
							//PlayerId = 0,
							PictureURL = "https://dotnethow.net/images/actors/actor-4.jpeg",
							Name = "Stepan",
							Surname = "Tryapkov",
							Gender = Gender.Female,
							BirthDate = new System.DateTime(1999, 1, 18),
							Team = context.Teams.FirstOrDefault(),
							Country = Country.Russia
						},
						new Player()
						{
							//PlayerId = 0,
							PictureURL = "https://dotnethow.net/images/actors/actor-5.jpeg",
							Name = "Hovard",
							Surname = "Elden",
							Gender = Gender.Male,
							BirthDate = new System.DateTime(1998, 12, 17),
							Team = context.Teams.FirstOrDefault(),
							Country = Country.Russia
						}
					});
				}
				context.SaveChanges();
			}
		}
	}
}
