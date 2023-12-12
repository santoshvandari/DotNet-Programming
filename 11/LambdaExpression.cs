using System;
class LambdaExpression{
    static void Main(){
        var sum=(a,b)=>a+b;
        Console.WriteLine("Sum : {0}",(sum(5,10)));
        
    }
}