﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowForm3
{
    [Serializable]
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }
    }
}
