using System;

namespace DemoHabitTracker.Models
{
    public class HabitOccasion
    {
        public int HabitId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public HabitRepeatValue RepeatValue { get; set; }
        public int RequiredTomatoes { get; set; }
        public string fkUserName { get; set; }
        public int OccasionId { get; set; }
        public DateTime ScheduledDate { get; set; }
        public ActivityStatus Status { get; set; }
    }
}
