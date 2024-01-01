/* Write a C# program to store id, name, age, address and salary of 5 employees in a list.
Now write LINQ query for the following:
• Select name and age of employees whose salary is greater than 20000 and age is less than 35.
• Select all records of employees whose name starts with letter ‘R’ and age greater than 25 in descending order based on age.
• Select all records of employee whose salary is maximum.
• Select id and name of employee whose salary is between 20000 and 30000.
• Select id and name of employees whose address is Btm and salary is greater than average salary of employees.
• Select records of employee group by address in ascending order based on age. */
using System;
using System.Linq;
using System.Collections.Generic;
class Employee{
    int id,age;
    double salary;
    string name,address;
    public Employee(int id,string name,int age,string address,double salary){
        this.id=id;
        this.name=name;
        this.age=age;
        this.address=address;
        this.salary=salary;
    }
}
class LINQQuery1{
    static void Main(){
        List<Employee> list = new Employee<Employee>();
        list.Add(new Employee(1,"ROhit",25,"KTM",20000));
        list.Add(new Employee(2,"Raj",30,"KVT",50000));
        list.Add(new Employee(3,"Ravi",35,"BTM",40000));
        list.Add(new Employee(4,"Rahul",40,"BRT",50000));
        list.Add(new Employee(5,"Krishna",45,"BTM",30000));
        //Select name and age of employees whose salary is greater than 20000 and age is less than 35.
        var res1 = from x in list
                    where x.salary>20000 && x.age<35
                    select new{x.name,x.age};
        
        foreach (var item in collection){
            
        }


    }
}