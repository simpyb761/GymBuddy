using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymBuddy.Data;
using GymBuddy.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace GymBuddy.Pages.Ben
{
    public class IndexModel : PageModel
    {
        private readonly GymBuddy.Data.GymBuddyContext _context;

        public IndexModel(GymBuddy.Data.GymBuddyContext context)
        {
            _context = context;
        }

        public IList<Exercises> Exercises { get;set; } = default!;
        [BindProperty(SupportsGet =true)]
        public string? SearchString { get; set; }
        public SelectList  ExperienceLevel { get; set; }
        [BindProperty(SupportsGet =true)]
        public string? UserExperience { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<GymBuddy.Models.TrainingLevel> experienceQuery = from m in _context.Exercises
                                                 orderby m.TrainingLevel
                                                 select m.TrainingLevel;
            var exercises = from m in _context.Exercises
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                exercises = exercises.Where(s => s.Name.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(UserExperience))
            {
                exercises = exercises.Where(x => x.TrainingLevel == Enum.Parse<TrainingLevel>(UserExperience));
            }
                ExperienceLevel = new SelectList(await experienceQuery.Distinct().ToListAsync());
                Exercises = await exercises.ToListAsync();
            
        }
    }
}
