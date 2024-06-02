using Catalogo.Modelos;


namespace Catalogo.Repositorio
{
    public interface IRepositorioHabitos
    {
        Task<Habito> Get(int id);
        Task<Habito> Add(Habito habitos);

        Task Delete(int id);
    }

}