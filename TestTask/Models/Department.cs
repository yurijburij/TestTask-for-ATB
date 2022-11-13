using System;
using System.Collections.Generic;

namespace TestTask.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Worker> Workers { get; set; }
    }
}
