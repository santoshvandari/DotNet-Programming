using System;
class Hello{
    public string Welcome(){
        return "Welcome,";
    }
}
class HelloWorld{
    static void Main(){
        Hello obj = new Hello();
        Console.WriteLine(obj.Welcome() + " Hello World");
    }
}