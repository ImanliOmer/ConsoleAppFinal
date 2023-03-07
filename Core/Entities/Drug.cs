﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Drug :BaseEntitie
    {
       
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public Drugstore DrugStore { get; set; }
    }
}
