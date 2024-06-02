using Catalogo.Modelos;

namespace Catalogo.Repositorio
{
    public interface IRepositorioPersonas
    {

        Task<List<Persona>> GetAll();
        Task<Persona?> Get(int id);
        Task<Persona> Add(Persona persona);

        Task<List<Clasificacion>> GetClasificaciones();

        Task<List<Habito>> GetHabitos(); 
        Task Update(int id, Persona persona);
        Task Delete(int id);
    }
}
