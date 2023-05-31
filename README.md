# ClassMethodsSub

The ClassMethodsSub project is a console application that demonstrates various concepts related to class methods in C#. It includes a class with different methods, including a void method, a method with output parameters, an overloaded method, and a static class. The Main() method of the console app instantiates the class, interacts with the user, and calls the different methods to showcase their functionality.

# Project Description
The ClassMethodsSub project consists of a single file named Program.cs.

Program.cs

This file contains the Main() method, which serves as the entry point of the application. It interacts with the user, instantiates an object of the class MathOperations, and calls the different methods to demonstrate their behavior.

The MathOperations class contains the following methods:

void DivideByTwo(int num)

Takes an integer parameter, num.

Divides the value of num by 2.

Outputs the result to the console.

void OutputParameters(int num1, int num2, out int sum, out int product)

Takes two integer parameters, num1 and num2.

Calculates the sum and product of the two numbers.

Outputs the sum and product using out parameters.

void OverloadedMethod(string str)

Takes a string parameter, str.

Displays a message indicating that the overloaded method with a string parameter is called.

void OverloadedMethod(int num)

Takes an integer parameter, num.

Displays a message indicating that the overloaded method with an integer parameter is called.

static class StaticClass

A static class declaration.

Contains static members or methods that can be accessed without creating an instance of the class.

# Instructions
Start the console application.

The program will instantiate an object of the MathOperations class.

The program will prompt the user to enter a number.

Enter an integer value for the number and press Enter.

The program will call the DivideByTwo() method on the entered number.

The program will display the result of the division on the screen.

Observe that the entered number is divided by 2 and displayed as the output.

The program will call the OutputParameters() method, passing in two integer values.

The program will display the sum and product of the two numbers on the screen.

Observe that the sum and product are calculated and displayed using out parameters.

The program will call the OverloadedMethod() method, passing in a string.

The program will display a message indicating that the overloaded method with a string parameter is called.

The program will call the OverloadedMethod() method, passing in an integer.

The program will display a message indicating that the overloaded method with an integer parameter is called.

The program will demonstrate the usage of a static class, which does not require instantiation.

The program will terminate, and you can rerun it to perform the method calls with different numbers and parameters.

# Skills Demonstrated
This project demonstrates the following skills and concepts related to class methods in C#:

Defining and implementing a void method

Performing calculations and outputting results

Using output parameters in a method

Overloading methods with different parameter types

Declaring and using a static class

Instantiating an object of a class

Interacting with the user through console input

Displaying results to the screen
