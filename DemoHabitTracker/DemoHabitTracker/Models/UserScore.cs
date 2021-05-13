using System.ComponentModel.DataAnnotations;

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
