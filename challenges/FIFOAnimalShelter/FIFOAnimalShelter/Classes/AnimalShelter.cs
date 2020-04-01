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
            OtherQ = new MyQueue<string>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="animal"></param>
        public void AnimalEnqueue(string animal)
        {
            if (animal == "dog")
            {
                DogQ.Enqueue(animal);
            }
            if (animal == "cat")
            {
                DogQ.Enqueue(animal);
            }
            else
            {
                OtherQ.Enqueue(animal);
            }
        }

        public void AnimalDequeue(string preference)
        {
            
        }
    }
}
