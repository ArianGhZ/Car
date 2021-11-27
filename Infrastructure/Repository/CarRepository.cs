using Domain.Models;
using Infrastructure.Persist;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly DatabaseContext _context;
        public CarRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void Add(Car car)
        {
            _context.Add(car);
            _context.SaveChanges();
        }


        public Task<List<Car>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetbyIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task Update()
        {
            throw new NotImplementedException();
        }
    }
}
