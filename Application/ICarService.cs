using Application.Commands;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public interface ICarService
    {
        void Add(AddCarCommand Command);
        
    }
}
