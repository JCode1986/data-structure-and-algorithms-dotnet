using FIFOAnimalShelter.Classes;
using System;
using Xunit;

namespace FIFIAnimalShelterTest
{
    public class UnitTest1
    {

        [Fact]
        public void CanInstantiateAnimalShelter()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.FIFOAnimalShelter();
        }
    }
}
