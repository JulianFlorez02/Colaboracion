using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webProfe.App.Frontend.Pages
{
    
    public class ListModel : PageModel
    {
        private string [] equipo = {"Equipo 1", "Equipo 2", "Equipo 3", "Equipo 4"};
        public List<String> Equipos {set;get;}
        public void OnGet()
        {
            Equipos = new List<string>();
            Equipos.AddRange(equipo);
        }
    }
}
