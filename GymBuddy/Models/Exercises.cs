﻿using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Xml.Linq;

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
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        [Display(Name = "Primary Muscle")]
        public string? PrimaryMuscle { get; set; }
        [Display(Name = "Secondary Muscle")]
        public string? SecondaryMuscle { get; set; }
        [Display(Name = "Training Level")]
        public TrainingLevel TrainingLevel { get; set; }
        
        [Required]
        [Display(Name = "Intensity Level")]
        public IntensityLevel IntensityLevel { get; set; }
        [Required]
        [Display(Name = "Have Completed")]
        public bool HaveCompleted { get; set; }

        [Required]
        [Display(Name = "Youtube Video")]
       [CustomValidation(typeof(AWValidation), "ValidateYoutubeLink")]
        public string? Video {  get; set; }
    }
    public class AWValidation
    {
        public static ValidationResult? ValidateYoutubeLink(string url)
        {
             if (string.IsNullOrWhiteSpace(url)) 
                {  
                return null; 
                } 
            else
            {
                if (Regex.IsMatch(url, "embed"))
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult("Please enter an embedded YouTube link!");
            }
            
        }
    }
}
