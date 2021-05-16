using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHabitTracker.Models
{
    public class Occasion //Occasion(PkId, ScheduledDate, Status,  fkHabitID)
    {
        [Key]
        public int OccasionId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ScheduledDate { get; set; }
        [Required]
        public ActivityStatus Status { get; set; }


        public int HabitId { get; set; }
        public Habit Habit { get; set; }
    }

    public enum ActivityStatus
    {
        Todo,
        Doing,
        Done
    }
}
