using System;
class TestProgram{
    static void Main(){
        string name = "Santosh     ";
        try{
            Console.WriteLine(name.Length);
            if(name.Length>10){
                throw new Exception("Length is More than 10 Characters.");
            }
            Console.WriteLine(name);
        }catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
}