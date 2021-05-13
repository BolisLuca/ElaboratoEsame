using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHabitTracker.Models
{
    public class Activity //Attività(pkid, titolo, descrizione, stato, data, Tomato_richiesti, fkAttivitàparent, fkemailUtente) 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pkid { get; set; }

        [Required, StringLength(30)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
        [Required]
        public ActivityStatus Status { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        public int Tomato_richiesti { get; set; }
        public int fkparentActivity { get; set; }
        [Required]
        public string fkUsernName { get; set; }

    }

    public enum ActivityStatus
    {
        Todo,
        Doing,
        Done
    }
}
