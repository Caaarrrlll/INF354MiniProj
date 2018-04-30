using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPTestRun.Data;
using ASPTestRun.Models;

namespace ASPTestRun.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ASPTestRun.Data.SchoolContext _context;

        public IndexModel(ASPTestRun.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Courses.ToListAsync();
        }
    }
}
