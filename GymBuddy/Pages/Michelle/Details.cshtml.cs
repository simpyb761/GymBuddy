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
    public class DetailsModel : PageModel
    {
        private readonly GymBuddy.Data.GymBuddyContext _context;

        public DetailsModel(GymBuddy.Data.GymBuddyContext context)
        {
            _context = context;
        }

      public Exercises Exercises { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Exercises == null)
            {
                return NotFound();
            }

            var exercises = await _context.Exercises.FirstOrDefaultAsync(m => m.Id == id);
            if (exercises == null)
            {
                return NotFound();
            }
            else 
            {
                Exercises = exercises;
            }
            return Page();
        }
    }
}
