using _66bitPractice.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _66bitPractice.Models
{
	public class Player
	{
		[Key]
		public int PlayerId { get; set; }

		public string PictureURL { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public Gender Gender { get; set; }

		public DateTime BirthDate { get; set; }

		public Country Country { get; set; }


		public int TeamId { get; set; }

		[ForeignKey("TeamId")]
		public Team Team { get; set; }
	}
}
