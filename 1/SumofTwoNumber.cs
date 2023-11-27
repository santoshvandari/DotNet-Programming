class SumofTwoNumber{
    public void Sum(){
        int a,b;
        Console.WriteLine("Enter a Two Number: ");
        a=Convert.ToInt32(Console.ReadLine());
        b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("sum of {0} and {1} is {2}.",a,b,(a+b));
    }
}