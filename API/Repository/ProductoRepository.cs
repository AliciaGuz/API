using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Entitys;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Repository
{

    public class ProductoRepository: IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductoRepository(ApplicationDbContext context)
        {
            _context = context; 
        }

        public async Task<IEnumerable<Productos>> FindAll()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<Productos?> GetById(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
            { 
                return null;
            }

            return producto;
        }
    }


}
