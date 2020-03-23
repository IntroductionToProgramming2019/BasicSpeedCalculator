/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : basic distance / time speed calculator 
 * 
 * ############################# */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_question
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Please enter the distance your car has covered in km: ");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Your distance is " + km + " kilometres");


            Console.WriteLine("Please enter the amount of time your car was travelling in hours: ");
           int time = int.Parse(Console.ReadLine());
            Console.WriteLine("Your time travelling was " + time + "hours");
            int kph = km / time;
            Console.WriteLine("Your speed was  " + kph);


        }
    }
}
