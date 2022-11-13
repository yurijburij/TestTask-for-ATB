using System;
using System.Collections.Generic;

namespace TestTask.Models
{
    public class Worker
    {
        public int ID { get; set; }
        public string Full_Name { get; set; }
        public int Id_department { get; set; }
        public DateTime Birthday { get; set; }
        public string Sex { get; set; }
        public string City { get; set; }

        public string Adress { get; set; }
        public string Phone_number { get; set; }
    }
}