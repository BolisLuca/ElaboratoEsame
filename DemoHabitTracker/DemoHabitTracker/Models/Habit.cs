using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHabitTracker.Models
{
    public class Habit //Habit(PkId, Title, Description, RepeatValue, RequiredTomatoes, fkUserName)
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HabitId { get; set; }

        [Required, StringLength(30)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        public HabitRepeatValue RepeatValue { get; set; }

        public int RequiredTomatoes { get; set; }

        [Required]
        public string fkUserName { get; set; }

        public ICollection<Occasion> Occasions { get; set; }

    }

    public enum HabitRepeatValue
    {
        Never,
        Daily,
        Weekly,
        Monthly
    }
}
