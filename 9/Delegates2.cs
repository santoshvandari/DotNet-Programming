using System;
class Delegates2{
    delegate void MyDel(int x, int y);
    static void Sum(int x, int y ){
        
    }
    static void Main(){
        Delegates1 obj= new Delegates1();
        Msg del = new Msg(obj.Message1);
        del=del+Message2;
        del();
    }
}