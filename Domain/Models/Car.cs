using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Car
    {
        public Car(string name, string companyName, DateTime produceDate, Engine engine)
        {
            ValidateProduceDate();
            Id = Guid.NewGuid();
            Name = name;
            CompanyName = companyName;
            ProduceDate = produceDate;
            Engine = engine;
        }
        public Car()
        {

        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string CompanyName { get; private set; }
        public Engine Engine { get; private set; }
        public DateTime ProduceDate { get; private set; }
        public void ValidateProduceDate()
        {
            if (this.ProduceDate.Year < 1990)
                throw new Exception(message: "Not Valid");
        }
    }
}
