﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg369Exercise
{
    class Bird
    {
        public string Name { get; set; }

        public virtual void Fly()
        {
            Console.WriteLine("Flap, flap");
        }

        public override string ToString()
        {
            return $"A bird named {Name}";
        }
    }
}
