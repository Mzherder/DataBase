﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Data
{
    class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Coach> Coaches { get; set; }
        public List<Player> Players { get; set; }
        public string Country { get; set; }
    }
}
