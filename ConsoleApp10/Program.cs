
using System;

class BankSystemATM
{
    static double balance = 0;

 
    static void ShowMenu()
    {
        Console.WriteLine("\n--- ATM Menu ---");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Exit");
        Console.Write("Choose an option: ");
    }


    static void CheckBalance()
    {
        Console.WriteLine($"Your current balance is: {balance:C}");
    }

 
    static void Deposit()
    {
        try
        {
            Console.Write("Enter amount to deposit: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            if (depositAmount > 0)
            {
                balance += depositAmount;
                Console.WriteLine($"Successfully deposited {depositAmount:C}. Your new balance is {balance:C}.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }


    static void Withdraw()
    {
        try
        {
            Console.Write("Enter amount to withdraw: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());

            if (withdrawAmount > 0 && withdrawAmount <= balance)
            {
                balance -= withdrawAmount;
                Console.WriteLine($"Successfully withdrew {withdrawAmount:C}. Your new balance is {balance:C}.");
            }
            else if (withdrawAmount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter an amount greater than zero.");
            }
            else
            {
                Console.WriteLine("Insufficient balance. Please enter a lower amount.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }


    static void Exit()
    {
        Console.WriteLine("Thank you for using the ATM. Goodbye!");
    }


    static void Main()
    {

        // Q1 : Create a C# application calculates the sum of the two provided integer values andreturns triple of the sum of the two numbers if they are equal.

        Console.WriteLine("Enter the first number : ");
        int Number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number : ");
        int Number2 = Convert.ToInt32(Console.ReadLine());
        int Sum = Number1 + Number2;

        Console.WriteLine(Number1 == Number2 ? $"triple of the sum of the first and second numbers are equal : {Sum * 3}" : $"triple of the sum of the first and second numbers are equal: {Sum}");

        // Q2 : Create a C# program to check a student's eligibility for voting by taking into consideration the student's age to be greater than 18.

        Console.WriteLine("\n\n");

        Console.WriteLine("Enter the student age : ");
        int age = Convert.ToInt32(Console.ReadLine());

        while (age < 0)
        {
            Console.WriteLine($"You entered the age ({age}) less than 0. Please re-enter the student’s age again : ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        if (age >= 18)
        {
            Console.WriteLine("The student is eligible to vote.");
        }

        else
        {
            Console.WriteLine("The student is NOT eligible to vote.");
        }

        // Q3 : Create a C# program that will receive a coordinate point as (x,y) and display the quadrant it is in : 

        Console.WriteLine("\n\n");

        Console.WriteLine("Enter x value : ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter y value : ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("The point is in the First Quadrant.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("The point is in the Second Quadrant.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The point is in the Third Quadrant.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("The point is in the Fourth Quadrant.");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("The point is at the Origin.");
        }
        else if (x == 0)
        {
            Console.WriteLine("The point is on the Y-axis.");
        }
        else if (y == 0)
        {
            Console.WriteLine("The point is on the X-axis.");
        }

        // Q4 : Write a C# program asks user to input the laterals only for triangle and then display the type of triangle if it is right, isosceles, or equilateral.

        Console.WriteLine("\n\n");

        Console.WriteLine("Enter the first side of the triangle:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second side of the triangle:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the third side of the triangle:");
        double side3 = Convert.ToDouble(Console.ReadLine());

        while (side1 > (side2 + side3) || side2 > (side1 + side3) || side3 > (side1 + side2))
        {
            Console.WriteLine("The dimensions of the triangle are incorrect. Please re-enter the correct dimensions");

            Console.WriteLine("\n");

            Console.WriteLine("Enter the first side of the triangle:");
            side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second side of the triangle:");
            side2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third side of the triangle:");
            side3 = Convert.ToDouble(Console.ReadLine());
        }

        double longestSide = Math.Max(side1, Math.Max(side2, side3));
        double otherSidesSum = 0;

        if (longestSide == side1)
        {
            otherSidesSum = Math.Pow(side2, 2) + Math.Pow(side3, 2);
        }
        else if (longestSide == side2)
        {
            otherSidesSum = Math.Pow(side1, 2) + Math.Pow(side3, 2);
        }
        else
        {
            otherSidesSum = Math.Pow(side1, 2) + Math.Pow(side2, 2);
        }

        if (longestSide * longestSide == otherSidesSum)
        {
            Console.WriteLine("The triangle is a right triangle.");
        }

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is Equilateral.");
        }

        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }

        // Q5 : 

        Console.WriteLine("\n\n");

        Console.Write("Enter the units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());

        while (age < 0)
        {
            Console.WriteLine($"the units consumed ({units}) less than 0. Please re-enter the units consumed : ");
            units = Convert.ToInt32(Console.ReadLine());
        }

        double rate = 0;
        double totalAmount = 0;
        double surcharge = 0;

        if (units < 300)
        {
            rate = 1.5;
        }
        else if (units < 450)
        {
            rate = 2;
        }
        else
        {
            rate = 2.5;
        }

        totalAmount = units * rate;

        if (units > 600)
        {
            surcharge = totalAmount * 0.10;
            totalAmount += surcharge;
        }

        Console.WriteLine("\n");

        Console.WriteLine($"Units Consumed  : {units} units");
        Console.WriteLine($"Charge per unit : {rate} per unit");
        Console.WriteLine($"Total Amount    : {totalAmount:C}"); 
        if (surcharge > 0)
        {
            Console.WriteLine($"Surcharge (10%) : {surcharge:C}");
        }

        // Exercise 2 :

        bool isRunning = true;

        while (isRunning)
        {
            ShowMenu(); 

            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        CheckBalance(); 
                        break;

                    case "2":
                        Deposit();
                        break;

                    case "3":
                        Withdraw(); 
                        break;

                    case "4":
                        Exit(); 
                        isRunning = false; 
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option from the menu.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        // Exercise 3 : 

        Console.WriteLine("\n\n");

        try
        {
            Console.Write("Enter the number of students : ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            if (numberOfStudents <= 0)
            {
                Console.WriteLine("Invalid number of students. Please enter a positive integer.");
                return;
            }

            double[] grades = new double[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
                {
                Console.Write($"Enter the grade for student {i + 1}: ");
                double grade = Convert.ToDouble(Console.ReadLine());

                if (grade >= 0 && grade <= 100)
                {
                    grades[i] = grade;
                }
                else
                {
                    Console.WriteLine("Invalid grade. Please enter a grade between 0 and 100.");
                    i--; 
                }
            }

            double minGrade = grades[0];
            double maxGrade = grades[0];
            double total = 0;

            foreach (double grade in grades)
            {
                if (grade < minGrade) minGrade = grade;
                if (grade > maxGrade) maxGrade = grade;
                total += grade;
            }

            double average = total / numberOfStudents;

            int aboveAverage = 0;
            int belowAverage = 0;

            foreach (double grade in grades)
            {
                if (grade > average) aboveAverage++;
                else if (grade < average) belowAverage++;
            }

          
            Console.WriteLine("\n--- Results ---");
            Console.WriteLine($"Minimum Grade: {minGrade}");
            Console.WriteLine($"Maximum Grade: {maxGrade}");
            Console.WriteLine($"Average Grade: {average:F2}");
            Console.WriteLine($"Number of students above average: {aboveAverage}");
            Console.WriteLine($"Number of students below average: {belowAverage}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values only.");
        }

        Console.ReadKey();
    }
}