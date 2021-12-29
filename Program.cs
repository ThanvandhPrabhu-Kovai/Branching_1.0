using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_1
{
    class Program
    {
        static void Main(string[] args)
        {
            checkTwoIntegersAreEqual();
            checkGivenNumberIsEvenOrOdd();
            checkWhetherNumberIsPositiveOrNegative();
            checkWhetherAGivenYearIsLeapYearOrNot();
            checkWhetherCandidateIsEligibleToCastVote();
            readAndShowOutputBasedOnInput();
            categorizePersonAccordingToHeight();
            getTheLargestOfThreeNumbers();
            determineQuadrantInXYCoordinateSystem();
            getAdmissionEligibilityForCourse();
            Console.ReadLine();
        }

        //program to accept two integers and check whether they are equal or not
        static void checkTwoIntegersAreEqual()
        {
            Console.Write("\n\nInput 1st number : ");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nInput 2nd number : ");
            int secondInt = Convert.ToInt32(Console.ReadLine());
            if (firstInt == secondInt)
            {
                Console.Write("\n\n{0} and {1} are equal", firstInt, secondInt);
            }
            else
            {
                Console.Write("\n\n{0} and {1} are not equal", firstInt, secondInt);
            }
        }

        //program to check whether a given number is even or odd
        static void checkGivenNumberIsEvenOrOdd()
        {
            Console.Write("\n\nCheck whether number is odd or even:");
            Console.Write("\n\n-----------------------------------");
            Console.Write("\n\nInput an integer: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            bool isInputIntegerEven = (userInput % 2) == 0;
            if (isInputIntegerEven)
            {
                Console.Write("\n\n{0} is an even integer", userInput);
            }
            else
            {
                Console.Write("\n\n{0} is an odd integer", userInput);
            }
        }

        //program to check whether a given number is positive or negative
        static void checkWhetherNumberIsPositiveOrNegative()
        {
            Console.Write("\n\nCheck whether a given number is positive or negative : ");
            Console.Write("\n\n --------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an integer : ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            bool isPositive = userInput >= 0;
            if (isPositive)
            {
                Console.Write("\n\n{0} is a positive number", userInput);
            }
            else
            {
                Console.Write("\n\n{0} is a negative number", userInput);
            }
        }

        //program to find whether a given year is a leap year or not
        static void checkWhetherAGivenYearIsLeapYearOrNot()
        {
            Console.Write("\n\nCheck whether a given year is leap year or not:");
            Console.Write("\n\n---------------------------------");
            Console.Write("\n\nInput an year : ");
            int inputYear = Convert.ToInt32(Console.ReadLine());
            bool condition1 = (inputYear % 400) == 0;
            bool condition2 = (inputYear % 100) == 0;
            bool condition3 = (inputYear % 4) == 0;
            Console.Write("\n\n");
            String leapYearStatement = "is a leap year";
            String notLeapYearStatement = "is not a leap year";
            void showOutput(bool isLeapYear) => Console.Write("{0} {1}", inputYear, isLeapYear ? leapYearStatement : notLeapYearStatement);
            if (condition1)
            {
                showOutput(true);
            }
            else
            {
                if (condition2)
                {
                    showOutput(false);
                }
                else
                {
                    if (condition3)
                    {
                        showOutput(true);
                    }
                    else
                    {
                        showOutput(false);
                    }
                }
            }
        }

        //program to read age of a candidate and determine whether it is eligible for casting his/her own vote
        static void checkWhetherCandidateIsEligibleToCastVote()
        {
            Console.Write("\n\nDetermine a specific age is eligible for casting the vote : ");
            Console.Write("\n\n--------------------------");
            Console.Write("\n\nInput the age of the candidate : ");
            int inputAge = Convert.ToInt32(Console.ReadLine());
            bool isNotEligible = inputAge < 18;
            if (isNotEligible)
            {
                int difference = 18 - inputAge;
                Console.Write("\n\nSorry, You are not eligible to cast your vote.");
                Console.Write("\n\nYou would be able to caste your vote after {0} years.", difference);
            }
            else
            {
                Console.Write("Congratulations! You are eligible tfor casting your vote.");
            }
        }

        //program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0
        static void readAndShowOutputBasedOnInput()
        {
            int m;
            int n;
            Console.Write("\n\nDisplay the value of n is 1, 0 and -1 for the value of er m : ");
            Console.Write("\n\n-------------------------");
            Console.Write("\n\nInput the value of m : ");
            m = Convert.ToInt32(Console.ReadLine());
            bool isMNot0 = (m != 0);
            bool isMGreaterThan0 = (m > 0);
            int assignValueToN(int value) => n = value;
            if (isMNot0)
            {
                if (isMGreaterThan0)
                {
                    assignValueToN(1);
                }
                else
                {
                    assignValueToN(-1);
                }
            }
            else
            {
                assignValueToN(0);
            }
            Console.Write("\n\nThe value of m = {0}", m);
            Console.Write("\n\nThe value of n = {0}", n);
        }

        //program to accept the height of a person in centimeter and categorize the person according to their height
        static void categorizePersonAccordingToHeight()
        {
            Console.Write("\n\nAccept the height of a person in centimeter and categorize them : ");
            Console.Write("\n\n----------------------------");
            Console.Write("\n\nInput the height of the person (in centimetres) : ");
            int inputHeight = Convert.ToInt32(Console.ReadLine());
            bool isDwarf = (inputHeight < 150.0);
            bool isAverageHeighted = (inputHeight >= 150.0 && inputHeight <= 165.0);
            bool isTaller = (inputHeight >= 165.0 && inputHeight <= 195.0);
            String output = isDwarf ? "The person is Dwarf." : isAverageHeighted ? "The person is average heighted" : isTaller ? "The person is taller" : "Abnormal Height";
            Console.Write("\n\n{0}", output);
        }

        //program to find the largest of three numbers
        static void getTheLargestOfThreeNumbers() {
            Console.Write("\n\nFind the largest of three numbers : ");
            Console.Write("\n\n----------------------------");
            Console.Write("\n\nInput the 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nInput the 2nd number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nInput the 3rd number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            String first = "1st";
            String second = "2nd";
            String third = "3rd";
            bool isNum1GreaterThanNum2 = num1 > num2;
            bool isNum1GreaterThanNum3 = num1 > num3;
            bool isNum2GreaterThanNum3 = num2 > num3;
            void showOutput(String positionOfTheLargestNumber) => Console.Write("The {0} is the greatest among three", positionOfTheLargestNumber);
            if (isNum1GreaterThanNum2) {
                if (isNum1GreaterThanNum3)
                {
                    showOutput(first);
                }
                else {
                    showOutput(third);
                }
            }
            else {
                if (isNum2GreaterThanNum3) {
                    showOutput(second);
                } else {
                    showOutput(third);
                }
            }
        }

        //program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies
        static void determineQuadrantInXYCoordinateSystem() {
            Console.Write("\n\nFind the quadrant in which the coordinate point lies :");
            Console.Write("\n\n--------------------------");
            Console.Write("\n\nInput the value for X coordinate :");
            int coordinate1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nInput the value for Y coordinate :");
            int coordinate2 = Convert.ToInt32(Console.ReadLine());
            bool isFirstQuadrant = (coordinate1 > 0 && coordinate2 > 0);
            bool isSecondQuadrant = (coordinate1 < 0 && coordinate2 > 0);
            bool isThirdQuadrant = (coordinate1 < 0 && coordinate2 < 0);
            bool isFourthQuadrant = (coordinate1 > 0 && coordinate2 < 0);
            bool isOrigin = (coordinate1 == 0 && coordinate2 == 0);
            void showOutput(String position) => Console.Write("The coordinate point ({0}, {1}) lies in the {2} quadrant", coordinate1, coordinate2, position);
            if (isFirstQuadrant)
            {
                showOutput("First");
            }
            else if (isSecondQuadrant)
            {
                showOutput("Second");
            }
            else if (isThirdQuadrant)
            {
                showOutput("Third");
            }
            else if (isFourthQuadrant)
            {
                showOutput("Fourth");
            }
            else if (isOrigin)
            {
                showOutput("Origin");
            }
            else {
                return;
            }
        }

        //program to find the eligibility of admission for a professional course based on the following criteria
        static void getAdmissionEligibilityForCourse() {
            Console.Write("\n\nFind eligibility for admission : ");
            Console.Write("\n\n--------------------------");
            Console.Write("\n\nEligibility criteria : ");
            Console.Write("\nMarks in Maths >= 65");
            Console.Write("\nand Marks in Phy >= 55");
            Console.Write("\nand Marks in Chem >= 50");
            Console.Write("\nand Total in all three subject >= 180");
            Console.Write("\nor Total in all three subject >= 140");
            Console.Write("\n\n--------------------------");
            Console.Write("\n\nInput the marks obtained in Physics : ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nInput the marks obtained in Chemistry : ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nInput the marks obtained in Maths : ");
            int m = Convert.ToInt32(Console.ReadLine());
            int totalMarks = (p + c + m);
            int sumOfMarksInMathsAndPhysics = (m + p);
            bool isEligibleInMaths = (m >= 65);
            bool isEligibleInPhysics = (p >= 55);
            bool isEligibleInChemistry = (c >= 50);
            bool isEligible = (isEligibleInMaths && isEligibleInPhysics && isEligibleInChemistry) && (totalMarks >= 180 || sumOfMarksInMathsAndPhysics >= 140);
            String isEligibleStatement = "The candidate is eligible for admission";
            String isNotEligibleStatement = "The candidate is not eligible";
            void showOutput(bool eligibility) => Console.Write("\n\n{0}", eligibility ? isEligibleStatement : isNotEligibleStatement);
            if (isEligible) {
                showOutput(true);
            } else {
                showOutput(false);
            }
        }
    } 
}
