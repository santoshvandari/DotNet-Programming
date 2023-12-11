using System;
class ActionDelegate{
    static void Sum(int x, int y){
        Console.WriteLine($"Sum of {x} and {y} is {(x+y)}");
    }
    static void Main(){
        Action<int,int> act = Sum;
        act(10,20);
    }
}