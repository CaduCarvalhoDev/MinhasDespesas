using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MinhasDespesas.Pages
{
    // [Authorize] garante que apenas usuários logados possam ver esta página
    [Authorize]
    public class HistoricoModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}