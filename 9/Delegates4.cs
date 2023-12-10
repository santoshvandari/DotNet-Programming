using System;
delegate void Calc(int n);
class Factorial{
    int fact=i=1;
    void Fact(int n){
        while(i<=n){
            fact*=i;
            i++;
        }
        Console.WriteLine($"Factorial of {n} is {fact}.");
    }
}
class Delegates4{
    static void Main(){
        
    }
}