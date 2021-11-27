using Application.Commands;
using Application.Mapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class CarService: ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository
            carRepository)
        {
            _carRepository = carRepository;
        }

        public CarService()
        {
            
        }

        public void Add(AddCarCommand Command)
        {
            var Car = Command.ToModel();
            _carRepository.Add(Car);
        }
    }
}
