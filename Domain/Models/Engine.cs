using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Engine
    {
        public Engine(double volume, int cylinder)
        {
            Id = Guid.NewGuid();
            Volume = volume;
            Cylinder = cylinder;

        }
        public Guid Id { get; private set; }
        public double Volume { get; private set; }
        public int Cylinder { get; private set; }
        public Engine()
        {

        }
    }
}
