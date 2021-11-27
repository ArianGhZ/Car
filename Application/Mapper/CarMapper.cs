using Application.Commands;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mapper
{
    public static class CarMapper
    {
        public static Car ToModel(this AddCarCommand command)
        {
            return new  Car (command.Name,command.CompanyName,command.ProduceDate,command.Engine.ToModel());
        }
        public static Engine ToModel(this AddEngineCommand command)
        {
            return new Engine(command.Volume, command.Cylinder); 
        }
    }
}
