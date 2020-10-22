using System;

namespace Line_Comparison_Computation
{
    class Program
    {
	/// <summary>
        /// Line Comparison Computation Program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

	    //Variables
            int x1, x2, y1, y2;

            Console.WriteLine("Enter x and y co-ordinates (x1,y1,x2,y2) for 1st line:");
            //Taking inputs from user for 1st line
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x1="+x1+" y1="+y1+" x2="+x2+" y2="+y2);

            //Finding length of first line
            int lengthOfLine1 = (int)Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Length of 1st line:"+lengthOfLine1);

	    int length1 = Convert.ToInt32(lengthOfLine1);

	    Console.WriteLine("Enter x and y co-ordinates (x1,y1,x2,y2) for 2nd line:");
            //Taking inputs from user for 1st line
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x1=" + x1 + " y1=" + y1 + " x2=" + x2 + " y2=" + y2);

            //Finding length of second line
            int lengthOfLine2 = (int)Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Length of 2nd line:" + lengthOfLine2);

	    int length2 = Convert.ToInt32(lengthOfLine2);

	    //Check two lines are equal or not
            if(length1.Equals(length2))
            {
                Console.WriteLine("Two lines are Equal.");
            }
            else
            {
                Console.WriteLine("Two lines are Not Equal.");
            }
        }
    }
}
