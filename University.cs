﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManager
{
    class University
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("Univeristy " + Name + "with ID " + Id);


        }

    }
}
