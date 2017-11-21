using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Ali Albayrak
// Student ID: P304320
// Date: 10/11/2017
/* Portfolio Activity 1.7 Documentation
 * In activity 2.2 and 2.3 you created a basic calculator and a 3rd party library. In this assessment activity
you will combine these two activities and create a fully functional calculator which links to a maths
library with a set of basic arithmetic and trigonometry functions.
Criteria
Each of these methods will require some research to ensure the correct values are displayed. For
example the Tan(90) is undefined and your calculator should display an “invalid” message. 
 */

namespace Trigonometric
{
    public class Trigonometric
    {

        //Sin Method: Accepts input as degree value and converts it to radian. Calculates Sine operation by using Sin method from Math library. 
        public static double Sine(double input)
        {
           double output = Math.Sin(DegreeToRadian(input));
            return (output);
        }

        //Cosine Method: Accepts input as degree value and converts it to radian. Calculates Cosine operation by using Cos method from Math library. 
        public static double Cosine(double input)
        {
            double output = Math.Cos(DegreeToRadian(input));
            return (output);
        }


        //Tan Method: Accepts input as degree value and converts it to radian. Calculates Tan operation by using Tan method from Math library. 
        public static double Tan(double input)
        {
            double output = Math.Tan(DegreeToRadian(input));
            return (output);
            
        }


        //DegreeToRadian method: A method for converting degrees to radian values
        public static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
