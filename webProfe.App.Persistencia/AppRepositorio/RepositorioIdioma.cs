using System.Collections.Generic;
using webProfe.App.Dominio;

namespace webProfe.App.Persistencia.AppRepositorio
{
    public class RepositorioIdioma : IRepositorioIdioma
    {
        List<Idioma> idiomas;
        public RepositorioIdioma(){
            idiomas = new List<Idioma>(){
                new Idioma{Id=1, Ingles="Programming", Frances="Programmation",Portugues="Programacao", Espanol ="Programacion"},
                new Idioma{Id=1, Ingles="Project", Frances="Projet",Portugues="Projeto", Espanol ="Projecto"}
            };
        }

        public IEnumerable<Idioma> GetAll()
        {
            return idiomas;
        }
        public Idioma GetIdiomaId(int IdiomaId)
        {
            return idiomas.SingleOrDefault(i => i.Id == IdiomaId);
        }
    }
}