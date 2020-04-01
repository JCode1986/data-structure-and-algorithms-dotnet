using FIFOAnimalShelter.Classes;
using System;
using Xunit;

namespace FIFIAnimalShelterTest
{
    public class UnitTest1
    {
        AnimalShelter shelter = new AnimalShelter();

        [Fact]
        public void CanInstantiateAnimalShelter()
        {
            shelter.FIFOAnimalShelter();
            bool actual = shelter.CatQ.IsEmpty() && shelter.DogQ.IsEmpty();
            Assert.True(actual);
        }

        [Fact]
        public void CanProperlyAddADog()
        {
            shelter.FIFOAnimalShelter();
            shelter.AnimalEnqueue("dog");
            string actual = shelter.DogQ.Front.Value;
            string expected = "dog";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanProperlyAddACat()
        {
            shelter.FIFOAnimalShelter();
            shelter.AnimalEnqueue("cat");
            string actual = shelter.CatQ.Front.Value;
            string expected = "cat";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ThrowsErrorIfAnimalBeingAddedIsNotACatOrDog()
        {
            shelter.FIFOAnimalShelter();
            Assert.Throws<Exception>(() => shelter.AnimalEnqueue("bird"));
        }

        [Fact]
        public void ThrowsErrorIfNoPreferenceToAdopt()
        {
            shelter.FIFOAnimalShelter();
            Assert.Throws<Exception>(() => shelter.AnimalDequeue("dog"));
        }

        [Fact]
        public void CanProperlyAdoptADog()
        {
            shelter.FIFOAnimalShelter();
            shelter.AnimalEnqueue("dog");
            shelter.AnimalDequeue("dog");
            bool actual = shelter.DogQ.IsEmpty();
            Assert.True(actual);
        }

        [Fact]
        public void CanProperlyAdoptACat()
        {
            shelter.FIFOAnimalShelter();
            shelter.AnimalEnqueue("cat");
            shelter.AnimalDequeue("cat");
            bool actual = shelter.CatQ.IsEmpty();
            Assert.True(actual);
        }

        [Fact]
        public void ReturnsNullIfAdoptedAnimalIsNotACatOrDog()
        {
            shelter.FIFOAnimalShelter();
            shelter.AnimalEnqueue("cat");
            shelter.AnimalEnqueue("dog");
            shelter.AnimalDequeue("bird");
            Assert.Null(shelter.AnimalDequeue("bird"));
        }

        [Fact]
        public void CanProperlyAddMulitpleDogsToShelter()
        {
            shelter.FIFOAnimalShelter();
            shelter.AnimalEnqueue("dog");
            shelter.AnimalEnqueue("dog");
            shelter.AnimalEnqueue("dog");
            string[] dogArray =
            {
                shelter.DogQ.Front.Value,
                shelter.DogQ.Front.Next.Value,
                shelter.DogQ.Front.Next.Next.Value,
            };
            int actual = dogArray.Length;
            int expected = 3;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanProperlyAddMulitpleCatsToShelter()
        {
            shelter.FIFOAnimalShelter();
            for (int i = 0; i < 5; i++)
            {
                shelter.AnimalEnqueue("cat");
            }
            shelter.AnimalDequeue("cat");
            string[] catArray =
            {
                shelter.CatQ.Front.Value,
                shelter.CatQ.Front.Next.Value,
                shelter.CatQ.Front.Next.Next.Value,
                shelter.CatQ.Front.Next.Next.Next.Value,
            };
            int actual = catArray.Length;
            int expected = 4;
            Assert.Equal(expected, actual);
        }

    }
}
