using Microsoft.EntityFrameworkCore;
using GymBuddy.Data;
using static System.Net.WebRequestMethods;

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
                        Video = "https://www.youtube.com/embed/trZQjegcRx0?si=3RBxe10Q84wdCbvr"
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
                        Video = "https://www.youtube.com/embed/8iPEnn-ltC8?si=oYNJJ-IqgcH7byu7"


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
                        Video = "https://www.youtube.com/embed/fIWP-FRFNU0?si=qcFyEbm4RHudTUcb"


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
                        Video = "https://www.youtube.com/embed/XGnOz-0ir8E?si=FASu1BGZn_b6z4cX"


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
                        Video = "https://www.youtube.com/embed/uYumuL_G_V0?si=dFTgxvHoquURKmXP"


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
                        Video = "https://www.youtube.com/embed/r4MzxtBKyNE?si=nu_CUJ8ZeOiSxMXA"
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
                        Video = "https://www.youtube.com/embed/rxD321l2svE?si=yLYIP2S8FIFSpAC_"


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
                        Video = "https://www.youtube.com/embed/taI4XduLpTk?si=8zHAeKxEmE7gBf3q"


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
                        Video = "https://www.youtube.com/embed/HCA4B1IDcAk?si=i4nDb2lqKLNK1D0X"


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
                        Video = "https://www.youtube.com/embed/G_8LItOiZ0Q?si=ZzW9yEz8EkMnD-Pn"
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
                        Video = "https://www.youtube.com/embed/LXkCrxn3caQ?si=PKZzn9T9EmUanaaM"
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
                        Video = "https://www.youtube.com/embed/qf6KO7qKFRI?si=zdy5ZPPi1DWMkAJT"


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
                        Video = "https://www.youtube.com/embed/ZXpdJOLNoWw?si=rYU3vWggPosMVY7d"


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
                        Video = "https://www.youtube.com/embed/DlhojghkaQ0?si=AUVrz6E7o0y0dukB"


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
                        Video = "https://www.youtube.com/embed/eMTy3qylqnE?si=px46ZptU0mkMzmoG"
                    }



                );
                context.SaveChanges();
            }
        }
    }
}
