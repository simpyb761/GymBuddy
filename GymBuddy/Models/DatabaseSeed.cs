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


                    },
                    new Exercises
                    {
                        Name = "DeadLift",
                        PrimaryMuscle = "Quads/Hamstring/Core/Trapezius",
                        SecondaryMuscle = "Glutes,Adductor Magnus",
                        IntensityLevel = "Medium",
                        TrainingLevel = "Intermediate",
                        Description = "Description",
                        HaveCompleted = false,
                    },
                    new Exercises
                    {
                        Name = "Bench Press",
                        PrimaryMuscle = "Pectoralis Major",
                        SecondaryMuscle = "Anterior Deltoid/Triceps",
                        IntensityLevel = "Low",
                        TrainingLevel = "Beginner",
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Cable Cross Over",
                        PrimaryMuscle = "Pectoralis Major",
                        SecondaryMuscle = "Pectoralis Minor/Anterior Deltoid",
                        IntensityLevel = "Low",
                        TrainingLevel = "Intermediate",
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Cable Row",
                        PrimaryMuscle = "Latissimus Dorsi",
                        SecondaryMuscle = "Spinal Erectors",
                        IntensityLevel = "Medium",
                        TrainingLevel = "Intermediate",
                        Description = "Description",
                        HaveCompleted = false,


                    },
                    new Exercises
                    {
                        Name = "Seated Hip Abductor",
                        PrimaryMuscle = "Gluteus Medius",
                        SecondaryMuscle = "Guteus Minimus",
                        IntensityLevel = "Low",
                        TrainingLevel = "Beginner",
                        Description = "Description",
                        HaveCompleted = false,
                    },
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
