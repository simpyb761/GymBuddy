using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GymBuddy.Data;
using GymBuddy.Models;

namespace GymBuddy.Pages.Ben
{
    public class DeleteModel : PageModel
    {
        private readonly GymBuddy.Data.GymBuddyContext _context;

        public DeleteModel(GymBuddy.Data.GymBuddyContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Exercises Exercises { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Exercises == null)
            {
                return NotFound();
            }
            var exercises = await _context.Exercises.FindAsync(id);

            if (exercises != null)
            {
                Exercises = exercises;
                _context.Exercises.Remove(Exercises);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }

      
    }
}
