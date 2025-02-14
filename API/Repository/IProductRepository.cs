using API.Entitys;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Productos>> FindAll();
        
        Task<Productos> GetById(int id); 
        Task<Productos> Create(Productos producto);
        Task Update (int id, Productos producto);
        Task Delete (int id);

    }
}
