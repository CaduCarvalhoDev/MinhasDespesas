using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MinhasDespesas.Pages
{
    // [Authorize] garante que apenas usuários logados possam ver esta página
    [Authorize]
    public class DashboardModel : PageModel
    {
        // A página não precisa de lógica C# (Get/Post)
        // porque o Blazor vai cuidar de tudo.
        public void OnGet()
        {
        }
    }
}