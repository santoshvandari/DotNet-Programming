// Write a C# program to demonstrate Join using LINQ.
using system;
using System.Linq;
using System.Collections.Generic;
class Student{
    int sid,cid;
    string sname,address;
    public Student(int sid,string sname,string address,int cid){
        this.sid=sid;
        this.sname=sname;
        this.address=address;
        this.cid=cid;
    }
}
class Course{
    int cid;
    string cname;
    public Course(int cid,string cname){
        this.cid=cid;
        this.cname=cname;
    }
}
class JoinLINQ{
    static void Main(){
        
    }
}