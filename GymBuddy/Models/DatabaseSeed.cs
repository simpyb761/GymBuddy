using Microsoft.EntityFrameworkCore;
using GymBuddy.Data;

namespace GymBuddy.Models
{
    public class DatabaseSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GymBuddyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GymBuddyContext>>()))
            {
                if (context == null || context.Exercises == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any existing exercises.
                if (context.Exercises.Any())
                {
                    return;   // If exercises exist, database has been seeded and no further action required.
                }
                // Otherwise seed database with this list.
                context.Exercises.AddRange(
                    new Exercises
                    {
                        Name = "Lat Pulldown",
                        PrimaryMuscle = "Latissimus Dorsi",
                        SecondaryMuscle = "Biceps",
                        IntensityLevel = "Low",
                        TrainingLevel = "Beginner",
                        Description = "Description",
                        HaveCompleted = false,
                    },
                    new Exercises
                    {
                        Name = "Incline Dumbell Press",
                        PrimaryMuscle = "Pectoralis Major",
                        SecondaryMuscle = "Triceps",
                        IntensityLevel = "Medium",
                        TrainingLevel = "Beginner",
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Preacher Curl",
                        PrimaryMuscle = "Biceps",
                        SecondaryMuscle = string.Empty,
                        IntensityLevel = "Low",
                        TrainingLevel = "Beginner",
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Muscle Ups",
                        PrimaryMuscle = "Latissimus Dorsi",
                        SecondaryMuscle = "Biceps/Triceps",
                        IntensityLevel = "High",
                        TrainingLevel = "Advanced",
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Front Squat",
                        PrimaryMuscle = "Quadriceps",
                        SecondaryMuscle = "Glutes",
                        IntensityLevel = "Medium",
                        TrainingLevel = "Intermediate",
                        Description = "Description",
                        HaveCompleted = false,


                    }

                );
                context.SaveChanges();
            }
        }
    }
}
