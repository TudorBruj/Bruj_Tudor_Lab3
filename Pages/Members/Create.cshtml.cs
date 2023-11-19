using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bruj_Tudor_Lab3.Data;
using Bruj_Tudor_Lab3.Models;

namespace Bruj_Tudor_Lab3.Pages.Members
{
    public class CreateModel : PageModel
    {
        private readonly Bruj_Tudor_Lab3.Data.Bruj_Tudor_Lab3Context _context;

        [BindProperty]
        public Member Members { get; set; }

        public CreateModel(Bruj_Tudor_Lab3.Data.Bruj_Tudor_Lab3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Member Member { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Member == null || Member == null)
            {
                return Page();
            }

            _context.Member.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
