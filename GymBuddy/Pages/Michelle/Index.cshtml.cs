using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GymBuddy.Data;
using GymBuddy.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;

namespace GymBuddy.Pages.Michelle
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
        public string SearchString { get; set; }
        public SelectList ExperienceLevel { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? ExperienceLev { get; set; }
        public string NameSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = sortOrder;
            IQueryable<GymBuddy.Models.TrainingLevel> experienceQuery = from e in _context.Exercises
                                                                        orderby e.TrainingLevel
                                                                        select e.TrainingLevel;
            var exercises = from e in _context.Exercises
                            select e;
            if (!string.IsNullOrEmpty(SearchString))
            {
                exercises = exercises.Where(e => e.Name.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(ExperienceLev))
            {
                exercises = exercises.Where(x => x.TrainingLevel == Enum.Parse<TrainingLevel>(ExperienceLev));
            }

            if (NameSort =="desc")
            {
                exercises = exercises.OrderByDescending(e => e.Name);
            }
            else
            {
                exercises = exercises.OrderBy(e =>  e.Name);
            }
            ExperienceLevel = new SelectList(await experienceQuery.Distinct().ToListAsync());
            
            Exercises = await exercises.ToListAsync();
        }
    }
}
