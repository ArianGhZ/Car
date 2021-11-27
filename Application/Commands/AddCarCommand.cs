using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands
{
    public class AddCarCommand
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public DateTime ProduceDate { get; set; }
        public AddEngineCommand Engine { get; set; }

    }
}
