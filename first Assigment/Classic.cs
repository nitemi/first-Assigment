using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_Assigment
{
     
        public class Classic

    { 
        public void classic()

    {
    start:

        Console.WriteLine("Please select a coffee 1 Blue cup coffee, 2 Red cup coffee, 3 Silver cup coffee ");
        int number = int.Parse(Console.ReadLine());


        switch (number)
        {
            case 1:
                Console.WriteLine("Blue cup coffee is #3000");
                break;

            case 2:
                Console.WriteLine("Red cup coffee is #4000");
                break;

            case 3:
                Console.WriteLine("Silver cup coffee is #6000");
                break;



            default:
                Console.WriteLine("Invalid order");
                break;

                    goto
                        start;
        }

        Console.WriteLine("Do you want another coffee --- Yes or No");
        string CustomerResponse = Console.ReadLine();

        if (CustomerResponse == "Yes")
        {
            goto
                start;
        }

        else
        {
            Console.WriteLine("Thanks for your patronage");
        }
    }

  }
}

