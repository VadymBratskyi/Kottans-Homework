﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtleBoats
{
    public class Submarine : Boats
    {
        public Submarine(uint x, uint y) : base(x, y)
        {
        }

        public Submarine(uint x, uint y, Direction direction) : base(x, y,3, direction)
        {
        }
        public Submarine(uint x, uint y, uint length, Direction direction) : base(x, y, length, direction)
        {
        }
    }
}
