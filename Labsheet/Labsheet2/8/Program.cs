// Write programs to show all usage of this keyword.(You must write separate programs for each usage)

using System;
class Person{
    public static string Name;
    static Person(){
        Name = "John";
    }
}
class Program{
    static void Main(){
        Console.WriteLine("Name of the Person : " + Person.Name);
    }
}