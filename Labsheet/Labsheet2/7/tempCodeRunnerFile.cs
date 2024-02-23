// Write a program to demonstrate static constructor. 
using System;
class Circle{
    public static float PI;
    static Circle(){
            PI = 3.14f;
    }
}
class Program{
    static void Main(){
        Console.WriteLine("Hello World!");
        Console.WriteLine("Value of PI is: " + Circle.PI);
    }
}

