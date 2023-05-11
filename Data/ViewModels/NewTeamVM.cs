using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _66bitPractice.Data.ViewModels
{
    public class NewTeamVM
    {
        public int Id { get; set; }
        [Required, Display(Name="Team Name")]
        public string Name { get; set; }
    }
}