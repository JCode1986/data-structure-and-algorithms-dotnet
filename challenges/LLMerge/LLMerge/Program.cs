using System;
using LinkedList.Classes;
using LinkList.Classes;

namespace LLMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Returns a 'zipped' linked list from two linked lists
        /// </summary>
        /// <param name="LL1">first linked list</param>
        /// <param name="LL2">second linked list</param>
        /// <returns></returns>
        public static Linklist LLMerge(Linklist LL1, Linklist LL2)
        {
            //throw exception if both linked lists are null
            if (LL1.Head == null && LL2.Head == null)
            {
                throw new Exception("Both linked lists are null");
            }
            //Return other linked list if one linked list is null
            if (LL1.Head == null || LL2.Head == null)
            {
                return LL1.Head == null ? LL2 : LL1;
            }

            //store both heads in a variable
            Node curr_A = LL1.Head;
            Node curr_B = LL2.Head;

            //traverse both trees, if neither is null
            while (curr_A.Next != null || curr_B.Next != null)
            {
                /*if first linked list is not null
                 store a reference it's next
                 point current to other linked list head
                 */ 
                if (curr_A.Next != null)
                {
                    Node temp_A = curr_A.Next;
                    curr_A.Next = curr_B;
                    
                    /* if second linked list is not null
                     store a reference to it's next
                     point current for second linked list to reference of first linked list
                     move both current forward for next iteration
                     */
                    if (curr_B.Next != null)
                    {
                        Node temp_B = curr_B.Next;
                        curr_B.Next = temp_A;
                        curr_B = temp_B;
                        curr_A = temp_A;
                    }
                    //if there is no next for second linked list, have it point to current of first linked list
                    else
                    {
                        curr_B.Next = temp_A;
                    }
                }
                //if current for first linked list is null, point it to current of second linked list
                if (curr_A.Next == null)
                {
                    curr_A.Next = curr_B;
                }
            }
            //return the zipped linked list
            return LL1;
        }
    }
}
