using System.Collections.Generic;
using webProfe.App.Dominio;

namespace webProfe.App.Persistencia.AppRepositorio
{
    public interface IRepositorioIdioma{
        IEnumerable<Idioma> GetAll();
        IdiomaVista GetIdiomaId(int id);
    }
    
}