using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Ali Albayrak
// Student ID: P304320
// Date: 10/11/2017
/* Portfolio Activity 1.6 & 1.7 (Documentation)
 * In activity 2.2 and 2.3 you created a basic calculator and a 3rd party library. In this assessment activity
you will combine these two activities and create a fully functional calculator which links to a maths
library with a set of basic arithmetic and trigonometry functions.
Criteria
Each of these methods will require some research to ensure the correct values are displayed. For
example the Tan(90) is undefined and your calculator should display an “invalid” message. 
 */

namespace Algebraic
{
    public class Algebraic
    {

        //SquareRoot method: Calculates and returns value of output by calling Sqrt method from Math library
        //This method is for calculating square root of any input(double type).
        public static double SquareRoot(double input)
        {
            double output = Math.Sqrt(input);
            return output;
        }


        //CubeRoot method: Calculates and returns value of output by calling Pow method from Math library
        //This method is for calculating cube root of any input(double type).
        public static double CubeRoot(double input)
        {
            if (input >= 0)                                      // Checks if input is equals or greater than zero
            {
                double output = Math.Pow(input, (1.0 / 3.0));        //Pow method is being used for root operations. We can change the level of root operation by changing dividing operation
                return output;
            }
            else
            {
                input = 0- input;                                    //If number is negative; convert it to positive number
                double output = Math.Pow(input, (1.0 / 3.0));        // Calculates cube root of positive number
                return -output;                                  // returns output as negative number
            }
        }


        //Inverse method: Calculates and returns value of output by dividing one by input.
        public static double Inverse(double input)
        {
            double output = 1 / input;           //Divides 1 by input
            return output;
        }
        
    }
}
