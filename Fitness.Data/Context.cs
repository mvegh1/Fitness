using Fitness.Database.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Database
{
    public class Context : DbContext
    {
        public Context()
        {
            System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<Fitness.Database.Context, Fitness.Database.Migrations.Configuration>(useSuppliedContext: true));
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutItem> WorkoutItems { get; set; }
    }
}
