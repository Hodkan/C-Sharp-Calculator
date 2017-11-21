using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Ali Albayrak
// Student ID: P304320
// Date: 10/11/2017
/* Portfolio Activity 1.6 & 1.7(Documentation)
 * In activity 2.2 and 2.3 you created a basic calculator and a 3rd party library. In this assessment activity
you will combine these two activities and create a fully functional calculator which links to a maths
library with a set of basic arithmetic and trigonometry functions.
Criteria
Each of these methods will require some research to ensure the correct values are displayed. For
example the Tan(90) is undefined and your calculator should display an “invalid” message. 
 */

namespace Arithmetic
{
    public class Arithmetic
    {
        //Add method: Add operation for two input, returns their add
        public static double Add(double firstNumber, double secondNumber)
        {
            return (firstNumber + secondNumber);
        }

        //Sub Method: Subtraction operation for two input, retruns their subtraction
        public static double Sub(double firstNumber, double secondNumber)
        {
            return (firstNumber - secondNumber);
        }

        //Div Method: Division operation; divides first number by second and returns double value
        public static double Div(double firstNumber, double secondNumber)
        {       
            return ((double)firstNumber / secondNumber);  
        }

        //Mult Method: Multiple operation; returns multiple of two inputs
        public static double Mult(double firstNumber, double secondNumber)
        {
            return (firstNumber * secondNumber);
        }
    }
}
