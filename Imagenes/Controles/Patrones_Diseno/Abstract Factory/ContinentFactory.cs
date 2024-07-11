﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles
{
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
