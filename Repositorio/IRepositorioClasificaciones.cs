using Catalogo.Modelos;

namespace Catalogo.Repositorio
{
    public interface IRepositorioClasificaciones
    {

        Task<Clasificacion?> Get(int id);
        Task<Clasificacion?> Add(Clasificacion clasificacion);

        Task Delete(int id);
    }
}
