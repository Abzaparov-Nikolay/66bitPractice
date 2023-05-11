using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _66bitPractice.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required, Display(Name="Team Name")]
        public string Name { get; set; }
        public List<Player> Players { get; set; }
    }
}
