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
                        IntensityLevel = IntensityLevel.Low,
                        TrainingLevel = TrainingLevel.Advanced,
                        Description = "Description",
                        HaveCompleted = false,
                    },
                    new Exercises
                    {
                        Name = "Incline Dumbell Press",
                        PrimaryMuscle = "Pectoralis Major",
                        SecondaryMuscle = "Triceps",
                        IntensityLevel = IntensityLevel.Medium,
                        TrainingLevel = TrainingLevel.Beginner,
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Preacher Curl",
                        PrimaryMuscle = "Biceps",
                        SecondaryMuscle = string.Empty,
                        IntensityLevel = IntensityLevel.Low,
                        TrainingLevel = TrainingLevel.Beginner,
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Muscle Ups",
                        PrimaryMuscle = "Latissimus Dorsi",
                        SecondaryMuscle = "Biceps/Triceps",
                        IntensityLevel = IntensityLevel.High,
                        TrainingLevel = TrainingLevel.Advanced,
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Front Squat",
                        PrimaryMuscle = "Quadriceps",
                        SecondaryMuscle = "Glutes",
                        IntensityLevel = IntensityLevel.Medium,
                        TrainingLevel = TrainingLevel.Intermediate,
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "DeadLift",
                        PrimaryMuscle = "Quads/Hamstring/Core/Trapezius",
                        SecondaryMuscle = "Glutes,Adductor Magnus",
                        IntensityLevel = IntensityLevel.High,
                        TrainingLevel = TrainingLevel.Intermediate,
                        Description = "Description",
                        HaveCompleted = false,
                    },
                    new Exercises
                    {
                        Name = "Bench Press",
                        PrimaryMuscle = "Pectoralis Major",
                        SecondaryMuscle = "Anterior Deltoid/Triceps",
                        IntensityLevel = IntensityLevel.Low,
                        TrainingLevel = TrainingLevel.Beginner,
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Cable Cross Over",
                        PrimaryMuscle = "Pectoralis Major",
                        SecondaryMuscle = "Pectoralis Minor/Anterior Deltoid",
                        IntensityLevel = IntensityLevel.Medium,
                        TrainingLevel = TrainingLevel.Beginner,
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Cable Row",
                        PrimaryMuscle = "Latissimus Dorsi",
                        SecondaryMuscle = "Spinal Erectors",
                        IntensityLevel = IntensityLevel.Low,
                        TrainingLevel = TrainingLevel.Intermediate,
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Seated Hip Abductor",
                        PrimaryMuscle = "Gluteus Medius",
                        SecondaryMuscle = "Guteus Minimus",
                        IntensityLevel = IntensityLevel.Low,
                        TrainingLevel = TrainingLevel.Beginner,
                        Description = "Description",
                        HaveCompleted = false,
                    },
                    new Exercises
                    {
                        Name = "Tricep Pushdown",
                        PrimaryMuscle = "Tricep",
                        SecondaryMuscle = String.Empty,
                        IntensityLevel = IntensityLevel.Medium,
                        TrainingLevel = TrainingLevel.Beginner,
                        Description = "Description",
                        HaveCompleted = false,
                    },
                    new Exercises
                    {
                        Name = "21s curls",
                        PrimaryMuscle = "Biceps",
                        SecondaryMuscle = String.Empty,
                        IntensityLevel = IntensityLevel.High,
                        TrainingLevel = TrainingLevel.Advanced,
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Overhead Barbell Press",
                        PrimaryMuscle = "Deltoids",
                        SecondaryMuscle = "Triceps",
                        IntensityLevel = IntensityLevel.High,
                        TrainingLevel = TrainingLevel.Advanced,
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Lunges",
                        PrimaryMuscle = "Quadriceps",
                        SecondaryMuscle = "Gluteus Maximus",
                        IntensityLevel = IntensityLevel.Medium,
                        TrainingLevel = TrainingLevel.Beginner,
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Calf Raise",
                        PrimaryMuscle = "Calves",
                        SecondaryMuscle = string.Empty,
                        IntensityLevel = IntensityLevel.Low,
                        TrainingLevel = TrainingLevel.Beginner,
                        Description = "Description",
                        HaveCompleted = false,
                    }



                );
                context.SaveChanges();
            }
        }
    }
}
