using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webProfe.App.Frontend.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioIdioma? repositorioIdioma;
        public Idioma Idioma{get;set;}

        public DetailsModel(IRepositorioIdioma repositorioIdioma)
        {
            this.repositorioIdioma = repositorioIdioma;
        }
        public void OnGet(int IdiomaId)
        {
            Idioma = repositorioIdioma.GetIdiomaId(IdiomaId);
            
        }
    }
}
