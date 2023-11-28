using System;

class SimpleInterest{
    public void Interest(){
        Console.Write("Enter Princial: ");
        int p=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Time: ");
        int t=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Rate: ");
        float r = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Simple Interst: "+((p*t*r)/100));
    }
}