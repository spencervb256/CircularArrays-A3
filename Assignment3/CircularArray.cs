using System;
using static System.Console;

namespace Assignment3
{
    public class CircularArray<T>
    {
        private T[] array;

        private int queueFront;
        private int queueRear;

        private int count;

        // Basic Constructor 
        // Creates an array and initializes the front and rear
        // O(1) in time O (N) in size
        public CircularArray(int size)
        {
            array = new T[size + 1];
            queueFront = 0;
            queueRear = 0;

            count = 0;


        }
        public void AddBack(T value)  //addBack is enqueue
        {

            if (count == array.Length)
            {
                WriteLine("Queue has no space");
                return;
            }
            else
            {

                array[queueRear] = value;
                queueRear = (queueRear + 1) % array.Length;

                count++;
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
