/// using System;

// namespace dotnet-crud // Note: actual namespace depends on the project name.
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }


// Add two ints and multiple the third
// int sum(int x, int y, int z)
// {
//   return (x + y) * z;
// }
// Console.WriteLine(sum(2, 4, 5));


// Celsius to Fahrenheit
// void cToF(int c)
// {
//   if (c < -271.15)
//   {
//     Console.WriteLine("Temperature below absolute zero!");
//     return;
//   }
//   var f = c * 1.8 + 32;
//   Console.WriteLine("T = {0}F", f);
// }
// cToF(0);
// cToF(100);
// cToF(-300);

// Return the arithmetic oprations of two ints
// string opr(int x, int y)
// {
//   if (y == 0)
//   {
//     return "Can't divide by Zero";
//   }
//   string res = (x + y) + ", " + (x - y) + ", " + (x * y) + ", " + (x / y);
//   return res;
// }
// Console.WriteLine(opr(3, 8));


// Swape two numbers
// int x = 87, y = 45;

// System.Console.WriteLine("Before swape");
// System.Console.WriteLine("x = " + x + " y = " + y);
// swape(ref x, ref y);
// System.Console.WriteLine("After swape");
// System.Console.WriteLine("x = " + x + " y = " + y);

// void swape(ref int x, ref int y)
// {
//   int a = x;
//   x = y;
//   y = a;
// }


// Check if number contains 3
// bool contains(int n)
// {
//   if (n <= 0) { return false; }
//   if (n % 10 == 3) { return true; }
//   return contains(n / 10);
// }

// Console.WriteLine(contains(7201432));
// Console.WriteLine(contains(87501));
