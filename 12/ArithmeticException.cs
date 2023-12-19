using System;
class ArithmeticException{
    static void Main(){
        try{
            
        }catch(ArithmeticException ex){
            Consoe.WriteLine("Error: {0}", ex.Message);
        }

    }
}