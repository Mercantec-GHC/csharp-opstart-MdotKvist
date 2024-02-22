﻿////Console.WriteLine("Signed integral types:");

////Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
////Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
////Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
////Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");


////Console.WriteLine("");
////Console.WriteLine("Unsigned integral types:");

////Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
////Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
////Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
////Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


////Console.WriteLine("");
////Console.WriteLine("Floating point types:");
////Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
////Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
////Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");




////int first = 2;
////string second = "4";
////string result = first + second;
////Console.WriteLine(result);


////int myInt = 3;
////Console.WriteLine($"int: {myInt}");

////decimal myDecimal = myInt;
////Console.WriteLine($"decimal: {myDecimal}");


////decimal myDecimal = 3.14m;
////Console.WriteLine($"decimal: {myDecimal}");

////int myInt = (int)myDecimal;
////Console.WriteLine($"int: {myInt}");



////string value = "bad";
////int result = 0;
////if (int.TryParse(value, out result))
////{
////    Console.WriteLine($"Measurement: {result}");
////}
////else
////{
////    Console.WriteLine("Unable to report the measurement.");
////}

////if (result > 0)
////    Console.WriteLine($"Measurement (w/ offset): {50 + result}");




//string[] values = { "12.3", "45", "ABC", "11", "DEF" };

//decimal total = 0m;
//string message = "";

//foreach (var value in values)
//{
//    decimal number; // stores the TryParse "out" value
//    if (decimal.TryParse(value, out number))
//    {
//        total += number;
//    }
//    else
//    {
//        message += value;
//    }
//}

//Console.WriteLine($"Message: {message}");
//Console.WriteLine($"Total: {total}");



int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;
decimal value32float = 0;

int result1 = Convert.ToInt32(value1 / value2);

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

value32float = Convert.ToDecimal(value3);
decimal result2 = value2 / value32float;

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");