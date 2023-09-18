using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GymBuddy.Data;
using GymBuddy.Models;

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
        public async Task OnGetAsync()
        {
            var exercises = from e in _context.Exercises
                            select e;
            if (!string.IsNullOrEmpty(SearchString))
            {
                exercises = exercises.Where(e => e.Name.Contains(SearchString));
            }
            Exercises = await exercises.ToListAsync();
        }
    }
}
