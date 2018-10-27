using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Database.Model
{
    public class Workout
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkoutId { get; set; }

        [ForeignKey("WorkoutType")]
        public int WorkoutTypeId { get; set; }
        public WorkoutType WorkoutType { get; set; }


        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Comments { get; set; }
    }
}
