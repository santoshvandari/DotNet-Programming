using System;
public static class A{
    public static void Msg(){
        Console.WriteLine("Class A");
    }
}
class B{
    static B(){
        Console.WriteLine("Static Constructor");
    }
    public B(){
        Console.WriteLine("Class B Constructor");
    }
}
class StaticConstructorandClass{
    static void Main(){
        A.Msg();
        new B();
        new B();
    }

}