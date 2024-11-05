// See https://aka.ms/new-console-template for more information


//Program to calculate the circumference of a circle based on the diameter
using System.ComponentModel;

Console.WriteLine("Enter the diameter of the circle: ");
double diameter = Convert.ToDouble(Console.ReadLine());
double circumference = Math.PI * diameter;
Console.WriteLine($"The circumference of the circle is: {circumference}");




//Program to calculate speed in meters per hour and kilometers per hour


Console.WriteLine("Enter the distance in meters: ");
double distance = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the time in hours: ");
double time = Convert.ToDouble(Console.ReadLine());

double speedMetersPerHour = distance / time;
double speedKilometersPerHour = (distance / 1000) / time;

Console.WriteLine($"Speed in meters per hour: {speedMetersPerHour} m/h");
Console.WriteLine($"Speed in kilometers per hour: {speedKilometersPerHour} km/h");






//Post - Increment Operator(x++)
// The original value is returned for use in the expression, and then the increment occurs.

int x = 5;
int y = x++; 
Console.WriteLine(x);
Console.WriteLine(y);

// Pre-Increment Operator (++x)
//The increment occurs first, and then the new value is returned for use in the expression.


int x1= 5;
int y1 = ++x; 
Console.WriteLine(x); 
Console.WriteLine(y);




// Program to round a double number to the nearest integer
Console.WriteLine("Enter a double number to round: ");
double numberToRound = Convert.ToDouble(Console.ReadLine());
double roundedNumber = Math.Round(numberToRound);
Console.WriteLine($"Rounded number: {roundedNumber}");



// Program to calculate base raised to the power of exponent
Console.WriteLine("Enter the base number: ");
double baseNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the exponent: ");
double exponent = Convert.ToDouble(Console.ReadLine());

double result = Math.Pow(baseNumber, exponent);

Console.WriteLine($"{baseNumber} raised to the power of {exponent} is: {result}");






// Program to check if a year is a leap year
Console.WriteLine("Enter a year: ");
int year = Convert.ToInt32(Console.ReadLine());

bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

if (isLeapYear)
{
    Console.WriteLine($"{year} is a leap year.");
}
else
{
    Console.WriteLine($"{year} is not a leap year.");
}





// Program to check if an alphabet is lowercase or uppercase
Console.WriteLine("Enter an alphabet: ");
char inputChar = Console.ReadKey().KeyChar;
Console.WriteLine(); 

if (Char.IsLower(inputChar))
{
    Console.WriteLine($"{inputChar} is a lowercase letter.");
}
else if (Char.IsUpper(inputChar))
{
    Console.WriteLine($"{inputChar} is an uppercase letter.");
}
else
{
    Console.WriteLine($"{inputChar} is not an alphabet.");
}



//Write a program to create a simple calculator (*/+-) using switch statement.
Console.WriteLine("Simple Calculator");
Console.WriteLine("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter an operator (+, -, *, /): ");
char operatorChoice = Console.ReadKey().KeyChar;
Console.WriteLine(); 
Console.WriteLine("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double result1;

switch (operatorChoice)
{
    case '+':
        result1 = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {result1}");
        break;
    case '-':
        result1 = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {result1}");
        break;
    case '*':
        result1 = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {result1}");
        break;
    case '/':
        if (num2 != 0)
        {
            result1 = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result1}");
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        break;
    default:
        Console.WriteLine("Invalid operator! Please use +, -, * or /.");
        break;
}




Console.WriteLine("Enter the first number: ");
int num12 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int num22 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
int num32 = Convert.ToInt32(Console.ReadLine());

// Using ternary operator to find the maximum number
int max = (num12 > num22)
    ? (num12 > num32 ? num12 : num32)
    : (num22 > num32 ? num22 : num32);

Console.WriteLine($"The maximum number is: {max}");




//Program to Check if a Number is Odd or Even Using Ternary Operator
Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

string result2 = (number % 2 == 0) ? "even" : "odd";

Console.WriteLine($"The number {number} is {result2}.");