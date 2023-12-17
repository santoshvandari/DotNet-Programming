using System;
class ExceptionHandeling{
    static void Main(){
        try{
            int a=10;
            Console.WriteLine("Division: {0}",(a/0));
        }catch(Exception e){
            Console.WriteLine("Error : {0}",e);
        }
    }
}