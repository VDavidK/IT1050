using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
     * This program was created by Vidir David Krogsgaard.
     * 1.28.18
     * (28th of January, 2018)
     */
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = null;
            string middleName = null;
            string middleInitial = null;
            string lastName = null;         // Assigned default values for the name portion of the program.
            string yesNo = null;
            
            int age = 0;
            bool isCitizen = false;         // Assigned default values for the age portion of the program
            bool canVote = false;

            int heightFeet = 0;
            double heightInches = 0.0;      // Assigned default values for the height portion of the program
            double totalHeightCM = 0.0;

            bool correctName = false;       // Loop-related values so program does not require a restart
            bool correctCitizenship = false;

            while (correctName == false)
                {
                Console.WriteLine("What is your first name? (for example: John)");                      // Checks for first name. Duh.
                firstName = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("What is your last name? (for example: Smith)");                      // Checks for last name. Duh.
                lastName = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("What is your middle name? (for example: S. Jessica P.");             // Checks for middle... ah screw it. You get it at this point, I hope.
                middleName = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("What is your middle name's first letter? (for example: J.");         // Y'know... life's like a box of chocolates. You either like it or don't.
                middleInitial = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Then that means your full name is " + firstName + " " + middleName + " " + lastName + ", and your middle initial is '" + middleInitial + "'. Is that correct? (Y/N)");

                yesNo = Console.ReadLine();

                if (yesNo == "Y") // Checks for uppercase 'Y'
                {
                    correctName = true;
                    Console.WriteLine("'Yes' detected. Continuing process. Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (yesNo == "y") // Checks for lowercase 'y'
                {
                    correctName = true;
                    Console.WriteLine("'Yes' detected. Continuing Process. Press any key to continue.");
                    Console.Clear();
                }
                else if (yesNo == "N") // Checks for uppercase 'N'
                {
                    correctName = false;
                    Console.WriteLine("'No' detected. Restarting process. Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (yesNo == "n") // Checks for lowercase 'n'
                {
                    correctName = false;
                    Console.WriteLine("'No' detected. Restarting process. Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else // If the input is invalid, it loops the process.
                {
                    correctName = false;
                    Console.WriteLine("Invalid input. Restarting process. Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (correctCitizenship == false)
            {
                Console.WriteLine("Are you a citizen of the United States of America? Y/N");        // Checks for citizenship status.
                yesNo = Console.ReadLine();

                if (yesNo == "Y")       // Somebody once told me
                {
                    isCitizen = true;
                    correctCitizenship = true;
                    Console.Clear();
                }
                else if (yesNo == "y")  // The world was gonna roll me
                {
                    isCitizen = true;
                    correctCitizenship = true;
                    Console.Clear();
                }
                else if (yesNo == "N")  // I ain't the sharpest tool in the shed.
                {
                    isCitizen = false;
                    correctCitizenship = true;
                    Console.Clear();
                }
                else if (yesNo == "n")  // Oof. Why did it have to be four lines of quotes.
                {
                    isCitizen = false;
                    correctCitizenship = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again."); // Reboots the citizen check if invalid input is present.
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine()); // Reads input and converts to the integer named "age"
            Console.Clear();

            if (age >= 18)  // Checks for age
            {
                canVote = true; // Assigns 'true' if you are 18 or older.
            }
            else
            {
                canVote = false; // Assigns 'false' if you are not 18 or older, i.e. 17 or younger.
            }

            // 
            Console.WriteLine("How tall are you in feet? (do not include inches)"); // Stores value for feet.
            heightFeet = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("How tall are you in inches? (do not include feet)"); // Stores value for inches.
            heightInches = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            totalHeightCM = (heightFeet * 30.48) + (heightInches * 2.54);   // Assigns heightFeet and heightInches to totalHeightCM, but converts both to their respective values in centimeters first.

            Console.WriteLine("You are " + heightFeet + " feet, and " + heightInches + " inches tall, which totals at " + totalHeightCM + " centimeters."); // Relatively repetitive code. In any case, this outputs your height in feet + inches and then in centimeters.
            Console.ReadKey();
            Console.Clear();

            // The big finale! Output of every relevant variable!
            Console.WriteLine("Your name is " + firstName + " " + middleName + " " + lastName + ", your middle initial is " + middleInitial + ".");
            Console.WriteLine("You are " + heightFeet + " feet, and " + heightInches + " inches tall.");
            Console.WriteLine("Your height in centimeters is " + totalHeightCM);
            if (isCitizen == true)
            {
                Console.WriteLine("You are a citizen of the United States of America. Unless you lied to me. How could you?");
            }
            else
            {
                Console.WriteLine("You are not a citizen of the United States of America.");
            }
            if (canVote == true)
            {
                Console.WriteLine("You are " + age + " years old, and could therefore vote.");
                if (isCitizen == false)
                {
                    Console.WriteLine("But since you're not a citizen, you can't do so anyway.");
                }
                else
                {
                    // No input, as it's irrelevant.
                }
            }
            else
            {
                Console.WriteLine("You are " + age + " years old, so you cannot vote");
                if (isCitizen == false)
                {
                    Console.WriteLine("But considering that you're not a citizen, that doesn't really matter.");
                }
                else
                {
                    // No input, as it's irrelevant.
                }
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("This concludes the program. Press any key to close it.");
            Console.ReadKey();
        }
    }
}
