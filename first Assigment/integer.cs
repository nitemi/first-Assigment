using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_Assigment
{
    public class Interactive

    {

        public Interactive()


        {
            Console.WriteLine("Please select a coffee 1-3");
            int coffee = int.Parse(Console.ReadLine());

            switch (coffee)
            {
                case 1:
                    Console.WriteLine("coffee 1 is #3000");
                    break;
                    case 2:
                    Console.WriteLine("coffee 2 is #5000");
                    break;
                    case 3:
                    Console.WriteLine("coffee 3 is #7500");
                    break;

                    default: 
                    Console.WriteLine("invalid order");
                    break;
            }
        }
    }
}
