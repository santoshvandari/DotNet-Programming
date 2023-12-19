using System;
class NullReferenceExceptionEx{
    static void Main(){
        string str="Santosh";
        try{
            Console.WriteLine(str.ToUpper());
        }catch(NullReferenceException ex){
            Console.WriteLine(ex);
        }
    }
}