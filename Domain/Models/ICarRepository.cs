using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public interface ICarRepository
    {
        
        void Add(Car car);
        Task<Car> GetbyIdAsync(Guid Id);
        Task<List<Car>> GetAllAsync();
        Task Update();
    }
}
