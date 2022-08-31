using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webProfe.App.Dominio;
using webProfe.App.Persistencia.AppRepositorio;

namespace webProfe.App.Frontend.Pages
{
    
    public class ListModel : PageModel
    {
        /*private string [] equipo = {"Equipo 1", "Equipo 2", "Equipo 3", "Equipo 4"};
        public List<String> Equipos {set;get;}*/

        private readonly IRepositorioIdioma? repositorioIdioma;
        public IEnumerable<Idioma>? Idiomas{get;set;}

        public ListModel(IRepositorioIdioma repositorioIdioma)
        {
            this.repositorioIdioma = repositorioIdioma;
        }

        public void OnGet()
        {
            //Equipos = new List<string>();
            //Equipos.AddRange(equipo);
            Idiomas=repositorioIdioma.GetAll();
        }
    }
}
