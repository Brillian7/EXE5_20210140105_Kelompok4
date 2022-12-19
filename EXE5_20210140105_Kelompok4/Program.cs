﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140105_Kelompok4
{
    class Program
    {
        int Brillian, Amindia, max = 5;
        int[] queue_array = new int[5];

        public Program()
        {
            /*Initializing the values of the variables REAR and FRONT to -1 indicate
            * * the queue is initially empty.*/
            Brillian = -1;
            Amindia = -1;
        }

        public void insert(int element)
        {

            /*This statement checks for the overflow condition. */
            if ((Brillian == 0 && Amindia == max - 1) || (Brillian == Amindia + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            /* This following statement checks whether the queue is empty if the queue
             * , then the value of the REAR and FRONT variables is set to 0 */
            if (Brillian == -1)
            {
                Brillian = 0;
                Amindia = 0;
            }
            else
            {
                /* If REAR is at the last position of the array, then the value of 
                 * REAR is set to 0 that corresponds to the first position of the array. */
                if (Amindia == max - 1)
                    Amindia = 0;
                else
                    /* if REAR is not at the last position, then its value is incremented by one */
                    Amindia = Amindia + 1;
            }
            /* Once the position of REAR is determined, the element is added at its proper place. */
            queue_array[Amindia] = element;

        }
        public void Delete()
        {
            /* checks wheather the queue is empty. */
            if (Brillian == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe element deleted from the queue is: " + queue_array[Brillian]
               + "\n");
            /* Check if the queue has one element. */
            if (Brillian == Amindia)
            {
                Brillian = -1;
                Amindia = -1;
            }
            else
            {
                /* if the element to be deleted is at the last position of the array, then the value
                * of FRONT is set to 0 i.e to the first elment of the array*/
                if (Brillian == max - 1)
                    Brillian = 0;
                else /* FRONT is incremented by one if it is not the first element of array. */
                    Brillian = Brillian + 1;
            }
        }

        public void display()
        {
            int Brillian_position= Brillian;
            int Amindia_position= Amindia;
            /* Checks if the queue is empty. */
            if (Brillian == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElements in the queue are.............................................\n");
            if (Brillian_position <= Amindia_position)
            {
                /*traverses the queue till the last element present in an array. */
                while (Brillian_position <= Amindia_position)
                {
                    Console.Write(queue_array[Brillian_position] + " ");
                    Brillian_position++;
                }
                Console.WriteLine();
            }
            else
            {
                /*traverses the queue till the last position of the array. */
                while (Brillian_position <= max - 1)
                {

                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
