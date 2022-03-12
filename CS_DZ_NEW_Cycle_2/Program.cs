using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_NEW_Cycle_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int givenNumber = random.Next(2, 20);
            int numberForTask = 2;
            int numberExponent = 1;
            int twoInExponent = 2;

            while (givenNumber > twoInExponent)
            {
                twoInExponent *= numberForTask;
                numberExponent++;
            }

            Console.WriteLine("Число из рандома - " + givenNumber);
            Console.WriteLine("Степень - " + numberExponent);
            Console.WriteLine("Двойка в " + numberExponent + " степени - " + twoInExponent);
        }
    }
}
