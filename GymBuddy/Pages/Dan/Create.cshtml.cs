using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GymBuddy.Data;
using GymBuddy.Models;

namespace GymBuddy.Pages.Dan
{
    public class CreateModel : PageModel
    {
        private readonly GymBuddy.Data.GymBuddyContext _context;

        public CreateModel(GymBuddy.Data.GymBuddyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Exercises Exercises { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Exercises == null || Exercises == null)
            {
                return Page();
            }

            _context.Exercises.Add(Exercises);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
