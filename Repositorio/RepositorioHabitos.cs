using Catalogo.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Repositorio
{
    public class RepositorioHabitos : IRepositorioHabitos
    {
        private readonly CatalogoDBContext _context;

        public RepositorioHabitos(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<Habito> Add(Habito habito)
        {
            await _context.Habitos.AddAsync(habito);
            await _context.SaveChangesAsync();
            return habito;
        }

        public async Task Delete(int id)
        {
            var habito = await _context.Habitos.FindAsync(id);
            if(habito != null)
            {
                _context.Habitos.Remove(habito);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Habito?> Get(int id)
        {
            return await _context.Habitos.FindAsync();
        }


    }
}
