using MyQueues;
using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public MyQueue<string> CatQ { get; set; } = null;
        public MyQueue<string> DogQ { get; set; } = null;
        public MyQueue<string> OtherQ { get; set; } = null;
        public void FIFOAnimalShelter()
        {
            CatQ = new MyQueue<string>();
            DogQ = new MyQueue<string>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="animal"></param>
        public void AnimalEnqueue(string animal)
        {
            if (animal != "dog" && animal != "cat")
            {
                throw new Exception("Must add a cat or dog");
            }
            if (animal == "dog")
            {
                DogQ.Enqueue(animal);
            }
            if (animal == "cat")
            {
                CatQ.Enqueue(animal);
            }
        }

        public string AnimalDequeue(string preference)
        {
            if (preference == "dog")
            {
                DogQ.Dequeue();
            }
            if (preference == "cat")
            {
                CatQ.Dequeue();
            }
            return null;
        }
    }
}
