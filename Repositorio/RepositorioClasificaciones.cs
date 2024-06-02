using Catalogo.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Repositorio
{
    public class RepositorioClasificaciones: IRepositorioClasificaciones
    {

        private readonly CatalogoDBContext _context;

        public RepositorioClasificaciones(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<Clasificacion> Add(Clasificacion clasificacion)
        {
            await _context.Clasificaciones.AddAsync(clasificacion);
            await _context.SaveChangesAsync();
            return clasificacion;
        }

        public async Task Delete(int id)
        {

            var clasificacion = await _context.Clasificaciones.FindAsync(id);
            if (clasificacion != null)
            {
                _context.Clasificaciones.Remove(clasificacion);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Clasificacion?> Get(int id)
        {
            return await _context.Clasificaciones.FindAsync(id);
        } 

 
    }
}
