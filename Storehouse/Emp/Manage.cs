﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storehouse.Emp
{
    public class Manage : Employee
    {
        public override void Position()
        {
            Console.WriteLine("Распорядитель обязанностей");
        }
    }
}
