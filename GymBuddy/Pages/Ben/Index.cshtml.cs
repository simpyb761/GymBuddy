using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using GymBuddy.Data;
using GymBuddy.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace GymBuddy.Pages.Ben
{

    public class IndexModel : PageModel
    {
        private readonly GymBuddy.Data.GymBuddyContext _context;

        public IndexModel(GymBuddy.Data.GymBuddyContext context)
        {
            _context = context;
        }

        public IList<Exercises> Exercises { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList ExperienceLevel { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? UserExperience { get; set; }
        public SelectList Intensity { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? UserIntensity { get; set; }
        public string NameSort { get; set; }
        public string CurrentSort { get; set; }
        public string CompletedSort { get; set; }
        public string PrimarySort { get; set; }
        public string SecondarySort { get; set; }
        public string TrainingSort { get; set; }
        public string IntensitySort { get; set; }


        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            CompletedSort = sortOrder == "Completed" ? "notCompleted" : "Completed";
            PrimarySort = sortOrder == "primary_desc" ? "primary_asc" : "primary_desc";
            SecondarySort = sortOrder == "secondary_desc" ? "secondary_asc" : "secondary_desc";
            TrainingSort = sortOrder == "training_desc" ? "training_asc" : "training_desc";
            IntensitySort = sortOrder == "intensity_desc" ? "intensity_asc" : "intensity_desc";

            var exercises = from m in _context.Exercises
                            select m;

            IQueryable<GymBuddy.Models.TrainingLevel> experienceQuery = from m in _context.Exercises

                                                                        select m.TrainingLevel;
            IQueryable<GymBuddy.Models.IntensityLevel> intensityQuery = from m in _context.Exercises
                                                                        select m.IntensityLevel;
            switch (sortOrder)
            {
                case "name_desc":
                    exercises = exercises.OrderByDescending(s => s.Name);
                    break;
                case "Completed":
                    exercises = exercises.OrderByDescending(_ => _.HaveCompleted);
                    break;
                case "notCompleted":
                    exercises = exercises.OrderBy(s => s.HaveCompleted);
                    break;
                case "primary_desc":
                    exercises = exercises.OrderByDescending(s => s.PrimaryMuscle);
                    break;
                case "primary_asc":
                    exercises = exercises.OrderBy(s => s.PrimaryMuscle);
                    break;
                case "training_desc":
                    exercises = exercises.OrderByDescending(s => s.TrainingLevel == TrainingLevel.Advanced ? 1 : s.TrainingLevel == TrainingLevel.Intermediate ? 2 : 3);
                    break;
                case "training_asc":
                    exercises = exercises.OrderBy(s => s.TrainingLevel == TrainingLevel.Advanced ? 1 : s.TrainingLevel == TrainingLevel.Intermediate ? 2 : 3);
                    break;
                case "intensity_desc":
                    exercises = exercises.OrderByDescending(s => s.IntensityLevel == IntensityLevel.High ? 1 : s.IntensityLevel == IntensityLevel.Medium ? 2 : 3);
                    break;
                case "intensity_asc":
                    exercises = exercises.OrderBy(s => s.IntensityLevel == IntensityLevel.High ? 1 : s.IntensityLevel == IntensityLevel.Medium ? 2 : 3);
                    break;
                default:
                    exercises = exercises.OrderBy(s => s.Name);
                    break;
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                exercises = exercises.Where(s => s.Name.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(UserExperience))
            {
                exercises = exercises.Where(x => x.TrainingLevel == Enum.Parse<TrainingLevel>(UserExperience));
            }
            if (!string.IsNullOrEmpty(UserIntensity))
            {
                exercises = exercises.Where(x => x.IntensityLevel == Enum.Parse<IntensityLevel>(UserIntensity));
            }
            ExperienceLevel = new SelectList(await experienceQuery.Distinct().ToListAsync());
            Intensity = new SelectList(await intensityQuery.Distinct().ToListAsync());
            Exercises = await exercises.ToListAsync();

        }
    }
}
