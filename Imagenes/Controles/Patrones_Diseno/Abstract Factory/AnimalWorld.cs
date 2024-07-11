using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles 
{
    class AnimalWorld
    {
        private Herbivore herbivore;
        private Carnivore carnivore;

        // Constructor
        public AnimalWorld(ContinentFactory factory)
        {
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }

        public string  EjecutarCadenaAlimenticia()
        {
            return carnivore.Come(herbivore);
        }
    }
}
