using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHabitTracker.Models
{
    public class UserScore
    {
        [Key]
        [Required]
        public string fkUserName { get; set; }
        [Required]
        public int Score { get; set; }
        [Required]
        public int MaxScore { get; set; }

    }
}
