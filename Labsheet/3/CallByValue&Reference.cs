// Write a C# program to illustrate call by value and call by reference.
using System;
class CallByValueAndReference{
    static void ByValue(int a){
        Console.WriteLine("By Value : {0}",a);
        a=10;
    }
    static void ByReference(ref int a){
        Console.WriteLine("By Reference : {0}",a);
        a=10;
    }
    static void Main(){

    }
}