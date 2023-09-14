using System.ComponentModel.DataAnnotations;
namespace GymBuddy.Models
{
    public class Exercises
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PrimaryMuscle { get; set; }
        public string? SecondaryMuscle { get; set; }
        public string TrainingLevel { get; set; }
        public string IntensityLevel { get; set; }
        public bool HaveCompleted { get; set; }

    }
}
