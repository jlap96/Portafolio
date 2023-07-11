using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo= "Papeleria",
                    Descripcion = "EPágina de comercio en HTML CSS y JavaScript",
                    Link = "http://amazon.com",
                    ImagenURL = "/img/papeleria.jpg"
                },

                new Proyecto
                {
                    Titulo= "Amazon",
                    Descripcion = "E-Commerce realizado en ASP.NET Core",
                    Link = "http://amazon.com",
                    ImagenURL = "/img/amazon.jpg"
                },

                new Proyecto
                {
                    Titulo= "Escuela Mayor",
                    Descripcion = "E-Commerce realizado en ASP.NET Core",
                    Link = "http://amazon.com",
                    ImagenURL = "/img/ControlEscolar.png"
                }
            };
        }
    }
}
