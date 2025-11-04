using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MinhasDespesas.Data;
using MinhasDespesas.Models;

namespace MinhasDespesas.Pages_Categorias
{
    public class IndexModel : PageModel
    {
        private readonly MinhasDespesas.Data.ApplicationDbContext _context;

        public IndexModel(MinhasDespesas.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Categoria> Categoria { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Categoria = await _context.Categorias.ToListAsync();
        }
    }
}
