using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Database.Model
{
    public class WorkoutType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkoutTypeId { get; set; }
        public string Name { get; set; }
    }
}
