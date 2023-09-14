using System.ComponentModel.DataAnnotations;

namespace GymBuddy.Models
{
    public enum TrainingLevel
    {
        Beginner,
        Intermediate,
        Advanced
    }
    public enum IntensityLevel
    {
        Low,
        Medium, 
        High
    }
    public class Exercises
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string PrimaryMuscle { get; set; }
        public string? SecondaryMuscle { get; set; }

        public TrainingLevel TrainingLevel { get; set; }
        
        [Required]
        public IntensityLevel IntensityLevel { get; set; }
        [Required]
        public bool HaveCompleted { get; set; }

    }
}
