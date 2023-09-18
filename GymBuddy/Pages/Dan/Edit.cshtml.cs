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

namespace GymBuddy.Pages.Dan
{
    public class EditModel : PageModel
    {
        private readonly GymBuddy.Data.GymBuddyContext _context;

        public EditModel(GymBuddy.Data.GymBuddyContext context)
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

            var exercises =  await _context.Exercises.FirstOrDefaultAsync(m => m.Id == id);
            if (exercises == null)
            {
                return NotFound();
            }
            Exercises = exercises;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Exercises).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExercisesExists(Exercises.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ExercisesExists(int id)
        {
          return (_context.Exercises?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
