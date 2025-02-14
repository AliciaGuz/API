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

        public async Task<Productos> Create(Productos producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
            return producto;
        }

        public async Task Update(int id, Productos producto)
        {
            var existingProduct = await _context.Productos.FindAsync(id);

            if (existingProduct == null)
            {
                throw new KeyNotFoundException("Producto no encontrado");
            }
            existingProduct.Nombre = producto.Nombre;
            existingProduct.Precio = producto.Precio;
            existingProduct.Stock = producto.Stock;

            await _context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto != null)
            {
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
            }

        }
    }


}
