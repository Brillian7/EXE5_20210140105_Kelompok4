using System;
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

        }
        static void Main(string[] args)
        {
        }
    }
}
