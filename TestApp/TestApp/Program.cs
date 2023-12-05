using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    /*
     * must contain a single class
     * should not contain any space
     * class name can be other than the file name
    */
    internal class Program
    {
        /*
         * CLR will search for the main method
         * Starting point of prog execution
         * Should have void -> which denotes that it don't return any value
         * can return int 1 or 0
         * 1 -> Error
         * 0 -> Program executed successfully
         * M should be upper case
         * should be static
         * A Static method can be executed without creating any object for the class
         * sting[] args is optional
        */
        static void Main(string[] args)
        {
            PrintNumberOfYearsDaysHoursMinSecBasedOnGivenNumberOfSeconds();
            /*
             * System is from Base Class Library which part of the .NET FRWK -> FRWK Class Library
             * Console is a class
             * WriteLine is a static method
             */
            /*
             * Console Class
             * class in System namespace
             * provides set of properties and methods to perform I/O operations in Console App
             * Static class, so all the members of "Console" class are accessible wihtout creating any object for the "Console" class.
             */
            /*
             * same as Write but moves the cursor to next line after the value
             */
            System.Console.WriteLine("HelloWorld");

            //returns no value and displays the parameter in console
            System.Console.Write("");

            //waits until the user presses any key on the keyboard
            //makes the console wait for the user's input
            //return type ConsoleKey
            //Key = J, KeyChar = 74 'J', Modifier = Shift
            /*
             An object that describes the ConsoleKey constant and Unicode character, if any, that correspond to the pressed console key. The ConsoleKeyInfo object also describes, in a bitwise combination of ConsoleModifiers values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key.
             */
            System.Console.ReadKey();

            /*
             * clears the console window
             * After cleaning u can display using Write or WriteLine
             */
            System.Console.Clear();

            /*
             * returns string type by default
             * even digits are treated as string
             */
            System.Console.ReadLine();

            /*
             * Variables
             * named memory location in RAM, to store a particular type of value, during the program execution
             * All variables are stored in STACK
             * For every method call, a new STATCH will be created.
             * variable's value can be changed any no. of times.
             * Local variables, after the completion of the method, the STACK will be deleted, also the local var
             * must be declared before its usage
             * must be initialized before reading its value
             * 
             * 
             * Declaration: DataType Variablename; or
             * DateType VariableName = Value;
             * 
             * Set and Get
             * 
             * Rules:
             * 1. Should contain spaces
             * 2. Should contain special char
             * 3. no duplicate names
             * 4. no keyword names should be used as var name
             */
            var r = 10;

            /*
             * Types -> what type we want to store in the variable
             * 
             * Primitive Types
             * (sbyete,
             * byte,
             * short,
             * ushort,
             * int,
             * uint,
             * long,
             * ulong,
             * float,
             * douable,
             * decimal,
             * char,
             * bool)
             * 
             * Strictly stores single value
             * building block of non-primitive values
             * 
             * Non-Primitive Types
             * (string,
             * classes,
             * Interfaces,
             * Stuctures,
             * Enumerations
             * )
             * 
             * stores one or more values
             * usually contains multiple members
             * 
             */
            /* 
             * sbyte (-128 to 128) D: 0
             */
            sbyte exampleSBYTE;
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);

            /*
             * byte (o to 255) D: 0
             */

            /*
             * short (-32,768 to 32,767) D: 0
             * 8 bits = 1 byte
             * 16-bit signed integer
             * 2^16 values
             */

            /*
             * ushort (0 - 65,535)
             * 16 bit, 2 bytes
             */

            /*
             * int (-2,147.483,648 to 2,147,483,647)
             * 4 bytes, 32 bits
             * any number written between the above numbers are treated as int in c#
             */

            /*
             * uint (0 to 4,294,967,295)
             */

            /*
             * long, ulong
             * 8 bytes , 64 bits
             */

            /*
             * float D: 0F
             * supports decimal points
             * 4 bytes, 32 bits
             * max decimal points supported: 7 digits
             */

            var f = 12.34F;

            /*
             * double
             * 8 bytes, 64 bits
             * decimal digits: 15 digits
             * D: 0D
             */

            /*
             * decimal
             * D: 0M
             * decimal digits: 28 digits
             * 16 bytes
             */

            /*
             * char
             * D: \0
             * single quotes
             * support all language
             * 2 bytes (0 to 137,994)
             * Unicode codes that rep characters
             * Unicode is subset of ASCII
             * Unicode = ASCII + other natural lang characters
             * ASCII (0 to 255) (only Eng lang char)
             */

            /*
             * 65 - 90 : A - Z
             * 97 - 122 : a - z
             * 48 - 57 : 0 - 9
             * 32: space
             * 8: Backspace
             * 13: Enter
             */

            var letter = '\0'; //rep NULL

            /*
             * string
             * no of char * 2 bytes
             * D: null
             */

            /*
             * bool
             * 1 bit
             * true or false
             * D: false
             */

            //to get default value of type
            var t = default(int);

            /*
             * Operators
             */
            /*
             + - / * %
             =
             ==, !=, <, >, >=, <=
             ++n, n++, --n, n++
             & -> evaluates both operands
             && -> first left, no right if first is false
            | -> evaluates both operands
            || 
            ^ (XOR)
                00 0
                01 1
                10 1
                11 0
            ! (Negation Operator)
            + string concatenation
            appending any type of value to string returns in string
            ?: (ternary opeartor)
             */

            /*
             * () [] ++ -- (postfix)
             * + - ! (unary)
             * * / % (multiplicative)
             * + - (Additive)
             * < <= > >= (Relational)
             * == != (equality)
             * &&
             * !!
             * ?:
             * = += -= *= /= %= (Assignment)
             */
            int a = 10 * 60 + 1;
            System.Console.WriteLine(a);

            int b = -10 * 60;
            System.Console.WriteLine(b);
        }

        //Assignment 2
        public void CalculateAreaOfCircle()
        {
            /*double is prefered*/
            float pi = 3.14159F;
            float radius = 10;
            float area = pi * radius * radius;
            System.Console.WriteLine(area); 
        }

        //Assignment 3
        public void CovertFeetToInches()
        {
            //inputs
            int feet = 5, inches = 7;

            //process
            //find number of inches based on number of feet
            int total_inches = (feet * 12) + inches;
            //find number of centimeters based on number of inches
            double centimeters = total_inches * 2.54;

            //output
            System.Console.WriteLine(centimeters);
            System.Console.ReadKey();
        }

        //Assignment 4
        /*
         Write a C# program to get nearest thousand of given integer number. Here, let name the input value as "number".
         */
        public static void PrintNearestThousand()
        {
            int number = 3452;
            int answer = (number + 500) / 1000 * 1000;
            Console.WriteLine(answer);
        }

        //Assignment 5
        /*
         * Write a C# program to print the number of years, days, hours, minutes, seconds - based on given number of seconds.
         */
        public static void PrintNumberOfYearsDaysHoursMinSecBasedOnGivenNumberOfSeconds()
        {
            int seconds = 288970;
            int days = (((seconds / 60) / 60) / 24);
            int hours = ((seconds / 60) / 60) - (days * 24);
            int min = (seconds / 60) - ((days * 24 * 60) + (hours * 60));
            int sec = seconds - ((days * 24 * 60 * 60) + (hours * 60 * 60) + (min * 60));
            Console.WriteLine(days + " days, "+ hours + " hours, " + min + " minutes, " + sec + " seconds");
        }
    }
}
