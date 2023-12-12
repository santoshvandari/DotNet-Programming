using System;
class AnonymousFunction{
    public delegate void MyDel(int x, int y);
    static void Main(){
        MyDel del = delegate(int x ,int y){
            Console.WriteLine("Sum : {0}\nDifference : {1}",(x+y),(x-y));
        };
        del(20,10);

    }
}