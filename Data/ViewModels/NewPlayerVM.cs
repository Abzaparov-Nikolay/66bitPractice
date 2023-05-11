using _66bitPractice.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace _66bitPractice.Data.ViewModels
{
	public class NewPlayerVM
	{
		public NewPlayerVM() { }

		public NewPlayerVM(Player player)
		{
			this.PlayerId = player.PlayerId;
			this.PictureURL = player.PictureURL;
			this.Name = player.Name;
			this.Surname = player.Surname;
			this.BirthDate = player.BirthDate;
			this.Gender = player.Gender;
			this.Country = player.Country;
			this.TeamId = player.TeamId;
		}


		public int PlayerId { get; set; }


		[Required, Display(Name = "Profile Picture")]
		public string PictureURL { get; set; }


		[Required, Display(Name = "Name")]
		[StringLength(50, ErrorMessage = "Lenght cannot exceed 50 chars")]
		public string Name { get; set; }


		[Required, Display(Name = "Surname")]
		[StringLength(50, ErrorMessage = "Lenght cannot exceed 50 chars")]
		public string Surname { get; set; }


		[Required, Display(Name = "Gender")]
		public Gender Gender { get; set; }


		[Required, Display(Name = "Birth Date")]
		public DateTime BirthDate { get; set; }


		[Required, Display(Name = "Team")]
		public int TeamId { get; set; }


		[Required, Display(Name = "Country")]
		public Country Country { get; set; }
	}
}
