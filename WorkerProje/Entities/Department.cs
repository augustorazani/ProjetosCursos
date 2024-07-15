using System;
using System.Collections.Generic;

namespace WorkerProje.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department()
        {
        }
        public Department(String name)
        {
            Name = name;
        }
    }
}
