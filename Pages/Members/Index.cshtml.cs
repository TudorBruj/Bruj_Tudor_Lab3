﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bruj_Tudor_Lab3.Data;
using Bruj_Tudor_Lab3.Models;

namespace Bruj_Tudor_Lab3.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Bruj_Tudor_Lab3.Data.Bruj_Tudor_Lab3Context _context;

        public IndexModel(Bruj_Tudor_Lab3.Data.Bruj_Tudor_Lab3Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}