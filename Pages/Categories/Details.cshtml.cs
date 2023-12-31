﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bruj_Tudor_Lab3.Data;
using Bruj_Tudor_Lab3.Models;

namespace Bruj_Tudor_Lab3.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Bruj_Tudor_Lab3.Data.Bruj_Tudor_Lab3Context _context;

        public DetailsModel(Bruj_Tudor_Lab3.Data.Bruj_Tudor_Lab3Context context)
        {
            _context = context;
        }

      public Category Category { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
