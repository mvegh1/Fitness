using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Database.Model
{
    public class WorkoutItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkoutItemId { get; set; }

        [ForeignKey("Workout")]
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }

        [ForeignKey("Exercise")]
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

        public int Sets { get; set; }
        public int Reps { get; set; }
        public decimal Weight { get; set; }
        public string Comments { get; set; }

    }
}
