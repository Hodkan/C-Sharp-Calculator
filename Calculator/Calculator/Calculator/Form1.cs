using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Name: Ali Albayrak
// Student ID: P304320
// Date: 20/10/2017
/* Portfolio Activity 1.6
 * In activity 2.2 and 2.3 you created a basic calculator and a 3rd party library. In this assessment activity
you will combine these two activities and create a fully functional calculator which links to a maths
library with a set of basic arithmetic and trigonometry functions.
Criteria
Each of these methods will require some research to ensure the correct values are displayed. For
example the Tan(90) is undefined and your calculator should display an “invalid” message. 
 */

namespace Calculator
{
    public partial class Form1 : Form
    {
        // Defining Boolean Flags for each arithmetric operation
        public bool Isplus = false;
        public bool Issub = false;
        public bool Isdiv = false;
        public bool Ismult = false;
        public double First;
        public double Result;

        public Form1()
        {
            InitializeComponent();
         
        }

        #region Number Buttons

        // Sets the display.text for each number button click.
        private void button0_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button0.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button9.Text;
        }

        #endregion

        #region Clear and Point Button

        //Clears Display textbox
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Display.Clear();
        }

        // Adds . (point) to Display textbox 
        private void buttonPoint_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + buttonPoint.Text;
        }
        #endregion

        #region Arithmetic Buttons
        //Add Button: sets display text as first value and turns plus flag to true. Later we can use this flag on equal operation.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                First += double.Parse(Display.Text);
            }
            catch       // If there is no text in Display textbox then this operation does not change first value.
            {
                First = First;
            }
            Display.Clear();        //Clears display
            Isplus = true;
            Issub = false;
            Isdiv = false;
            Ismult = false;
        }


        //Sub Button: Checks if this button used for negative numbers or operation.
        //If it is used on purpose of negative number, then displays (-) sign on display textbox
        //if it is used on purpose of subtraction ,sets display text as first value and turns sub flag to true. Later we can use this flag on equal operation.
        private void buttonSub_Click(object sender, EventArgs e)
        {

            if (Isplus == false && Issub == false && Isdiv == false && Ismult == false) // Checks if any of operation used before
            {
                //if no operation is used before
                try    //try act like normal subtraction operation
                {
                    First += double.Parse(Display.Text);
                    Display.Clear();
                    Isplus = false;
                    Issub = true;
                    Isdiv = false;
                    Ismult = false;
                }
                catch  //if there is no value on Display.Text(this means user wants to enter a negative number)
                {
                    First = 0;
                    Display.Text = Display.Text + buttonSub.Text;    //Adds - sign to Display.text for negative number               
                }

          
            }

            else if(Issub == true)  //if sub operation is used before (this means buttonsub is being used on purpose of negative number (second number of operation))
            {
                Display.Clear();  
                Display.Text = Display.Text + buttonSub.Text;     //Adds - sign to Display.text for negative number  
            }

            else  //if any other operation is used before (this means buttonsub is being used on purpose of negative number (second number of operation))
            {
                Display.Text = Display.Text + buttonSub.Text;          
            }
            
          
        }


        //Mult Button: sets display text as first value and turns mult flag to true. Later we can use this flag on equal operation.
        private void buttonMult_Click(object sender, EventArgs e)
        {
            try
            {
                First += double.Parse(Display.Text);
            }
            catch   // If there is no text in Display textbox then this operation does not change value of first.
            {
                First = First;
            }
            Display.Clear();
            Isplus = false;
            Issub = false;
            Isdiv = false;
            Ismult = true;
        }


        //Div Button: sets display text as first value and turns div flag to true. Later we can use this flag on equal operation.
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            try
            {
                First += double.Parse(Display.Text);
            }
            catch
            {
                First = First;
            }
            Display.Clear();
            Isplus = false;
            Issub = false;
            Isdiv = true;
            Ismult = false;

        }

        //By using the flags we set earlier, decides which method operation from impoted libraries to be used.
        private void buttonEq_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Display.Text))     // Checks if display.text is empty or null
            {
                try
                {
                    Result = First;         //if it display.text is empty and first has a value, set result value as first value
                }
                catch
                {
                    Result = 0;             // if first has not a value then set result`s value as 0.
                }
                Display.Text = Result.ToString();
                First = 0;
            }
            else  // If Display.text has value checks flags and does appropriate operation by calling suitable methods from imported library.
            {
                if (Isplus == true)
                {
                    Result = Arithmetic.Arithmetic.Add(First, double.Parse(Display.Text));
                }
                else if (Issub == true)
                {
                    Result = Arithmetic.Arithmetic.Sub(First, double.Parse(Display.Text));
                }
                else if (Ismult == true)
                {
                    Result = Arithmetic.Arithmetic.Mult(First, double.Parse(Display.Text));
                }
                else if (Isdiv == true)
                {
                    if (double.Parse(Display.Text) == 0)  //Checks if divider is zero and displays error message.
                    {
                        MessageBox.Show("Divider cannot be 0 !");
                        First = 0;
                        Result = 0;
                        Display.Clear();
                    }
                    else
                    {
                        Result = Arithmetic.Arithmetic.Div(First, double.Parse(Display.Text));
                    }
                }

                Display.Text = Result.ToString();
                First = 0;
                Isplus = false;
                Issub = false;
                Isdiv = false;
                Ismult = false;
            }
        }
        #endregion

        #region Trigonometric Buttons

        //Sin Button: Checks if input is empty or has a critic value. Then,calculates sin value of Display.text by calling Sine method from imported library.
        private void buttonSin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Display.Text))
            {
                try
                {
                    Result = Trigonometric.Trigonometric.Sine(First);
                }
                catch
                {
                    Result = 0;
                }
                
            }
            else
            {
                double input = double.Parse(Display.Text);
                double remainder = input % 90;                          // Checks if input is multiple of 90(degrees)
                if (remainder == 0)
                {
                    double multiple = input / 90;                     //Calculates and checks if multiple value is even or odd
                    double even = multiple % 2;
                    if (even != 0)                             //if it is odd 
                    {
                        Result = Trigonometric.Trigonometric.Sine(double.Parse(Display.Text));     //calculates result value by calling Sine method from imported library
                    }
                    else
                    {                 
                        Result = 0;                         //if it is even.  This part is for value of sin 180 or sin(180+180k).
                                                           //I noticed there were some errors for these values on default sin operation(because it is designed for radius). 
                    }
                }
                else
                {
                    Result = Trigonometric.Trigonometric.Sine(double.Parse(Display.Text));
                }
            }
         
            Display.Text = Result.ToString();
            First = 0;
        }

        //Cos Button:Checks if input is empty or has a critic value. Then, calculates cos value of Display.text by calling Cosine method from imported library.
        private void buttonCos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Display.Text))
            {
                try
                {
                    Result = Trigonometric.Trigonometric.Cosine(First);
                }
                catch
                {
                    Result = 0;
                }

            }
            else
            {
                double input = double.Parse(Display.Text);
                double remainder = input % 90;                          // Checks if input is multiple of 90(degrees)
                if (remainder == 0)
                {
                    double multiple = input / 90;                     //Calculates and checks if multiple value is even or odd
                    double even = multiple % 2;
                    if (even != 0)                              //if it is odd 
                    {
                        Result = 0;                          //This part is for value of cos 90 or cos(90+180k).
                                                             //I noticed there were some errors for these values on default cos operation(because it is designed for radius).
                    }
                    else
                    {
                        Result = Trigonometric.Trigonometric.Cosine(double.Parse(Display.Text));        //calculates result value by calling Cosine method from imported library
                    }
                }
                else
                {
                    Result = Trigonometric.Trigonometric.Cosine(double.Parse(Display.Text));  
                }               
            }

            Display.Text = Result.ToString();
            First = 0;
        }

        //Tan Button: Checks if input is empty or has a critic value. Then, calculates tan value of Display.text by calling Tan method from imported library.
        private void buttonTan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Display.Text))
            {
                try
                {
                    Result = Trigonometric.Trigonometric.Tan(First);
                }
                catch
                {
                    Result = 0;
                }

            }
            else
            {
                double input = double.Parse(Display.Text);
                double remainder = input % 90;                          // Checks if input is multiple of 90(degrees)
                if (remainder == 0)
                {
                    double multiple = input / 90;                     //Calculates and checks if multiple value is even or odd
                    double even = multiple % 2;
                    if (even != 0)                               //If it is odd that means tan has not any valid value on these numbers  - tan(90+180k) = Invalid
                    {
                        MessageBox.Show("Invalid value! Tan method has no valid value on " + input);      // Displays error message                 
                    }
                    else
                    {
                        Result = 0;                                                         
                    }
                }
                else
                {
                    Result = Trigonometric.Trigonometric.Tan(double.Parse(Display.Text));          //calculates result value by calling Tan method from imported library
                }
                
            }

            Display.Text = Result.ToString();
            First = 0;
        }
        #endregion

        #region Algebraic Buttons
        //SQRT Button: Checks if input is empty or less than zero. Then, calculates square root of value of the Display.text
        private void buttonSQRT_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Display.Text))         // Checks if Display.Text is empty or null
            {
                try
                {
                    Result = Algebraic.Algebraic.SquareRoot(First);       // Sets the value of result by using first value to call SquareRoot method from imported library.
                }
                catch
                {
                    Result = 0;
                }

            }
            else
            {
                if (double.Parse(Display.Text) < 0)                     // Checks if input is less than zero
                {
                    MessageBox.Show("Number cannot be negative!");          // Displays message box as error
                    Display.Clear();
                }
                
                else
                {
                    Result = Algebraic.Algebraic.SquareRoot(double.Parse(Display.Text));        //Calculates result by calling SquareRoot method from imported library
                    Display.Text = Result.ToString();
                    First = 0;
                }
            }          
        }

        //CRT Button:Checks if input is empty.Then, calculates Cube Root of input.
        private void buttonCRT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Display.Text))                  // Checks if input is empty or null
            {
                try
                {
                    Result = Algebraic.Algebraic.CubeRoot(First);       //If input is empty, try to use previous input
                }
                catch
                {
                    Result = 0;                                         //if there is no input set result as 0
                }

            }
            else
            {
                Result = Algebraic.Algebraic.CubeRoot(double.Parse(Display.Text));      //Calculates result by calling CubeRoot method from imported library
            }

            Display.Text = Result.ToString();
            First = 0;
        }

        //INV Button: Checks if input is empty or equals to 0. Then, calculates inverse of the input (1/x)
        private void buttonINV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Display.Text))              // Checks if input is empty or null
            {
                try
                {
                    Result = Algebraic.Algebraic.Inverse(First);        //If input is empty, try to use previous input
                }
                catch
                {
                    Result = 0;                                          //if there is no input set result as 0
                }

            }
            else
            {
                if (double.Parse(Display.Text) == 0)                        // Checks if input is zero
                {                   
                    MessageBox.Show("Undefined! Please enter a number other than 0 !");     //Displays error message
                    Display.Clear();             
                }
                else
                {
                    Result = Algebraic.Algebraic.Inverse(double.Parse(Display.Text));       //Calculates result by calling Inverse method from imported library
                    Display.Text = Result.ToString();
                    First = 0;
                }
            }


        }
        #endregion

        #region Menu Buttons
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) ==              //Displays Message when clicked on quit menu section
         DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion
    }
    
}
