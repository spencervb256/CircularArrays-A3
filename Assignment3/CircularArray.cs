using System;
using static System.Console;

namespace Assignment3
{
    public class CircularArray<T>
    {
        private T[] array;

        private int queueFront;
        private int queueRear;

        private int priority;

        private int count;

        // Basic Constructor 
        // Creates an array and initializes the front and rear
        // O(1) in time O (N) in size
        public CircularArray(int size)
        {
            array = new T[size + 1];
            queueFront = 0;
            queueRear = 0;

            priority = 0;

            count = 0;


        }

        public void AddFront(T value, int priority)  //Add the highest priority at the front
        {


            int startOfShuffling; //This handles where to start reorganizing the queue from

            //PRIORITY 1 ADDS TO FRONT OF QUEUE

            //assign prioirty to element being added

            //Change priority if current element if gets overwritten


            if (count == array.Length)
            {
                WriteLine("Queue has no space");
                return;
            }

            //insert at front
            array[priority] = value;
            queueFront = (queueFront + 1) % array.Length;


            //check that it can go in the position, and if not, move everything from that point on down

            //TRAVERSE ARRAY AND START MOVING DOWN FROM LAST FILLED ELEMENT IN ARRAY

            if (array[priority] != default)
            {
   

                //traverse array and move everything down, starting at end
                for (int i = priority; i < array.Length; i++)
                {

                    //find the last position that's filled
                    if (array[i + 1]  == default)
                    {
                        startOfShuffling = i;
                        
                        break;
                    }
            
                   
                }
                for (int i = startOfShuffling; i >= 0; i--)
                {

                }
                

            }
            





            for (int i = 0; i < array.Length; i++)
            {
            
            }


            


        }

        public void Delete()
        {

            if (count == 0)
            {


                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("The following was just removed : " + array[queueFront]);

                queueFront = (queueFront + 1) % array.Length;

                count--;
            }
        }
        public void PrintAll()
        {
            //print off all the elements in the array
        }
        public void DeleteAll()
        {
            //Delete all the elements in the array
        }

        // Just returns the front element O(1)
        public T GetFront()
        {
            if (array != null)
            {
                return array[queueFront];
            }


            //Grow(array.Length * 2);
            WriteLine("Empty queue");
            return default;

        }

        public void Grow(int newsize)
        {
            int count = this.count;
            T[] arrayCopy = new T[newsize];




            //Pop off front of list and add to back of new list
            for (int i = 0; i < count; i++)
            {
                arrayCopy[i] = GetFront();
                Delete();



            }
            array = arrayCopy;

            queueFront = 0;
            this.count = count;
            queueRear = count;



        }
    }
}
