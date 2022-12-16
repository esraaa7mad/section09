﻿using System;
public  class Person{
 public string Name;
 public int Age;
 public Person(string name,int age)
 {
  if(name == null || name=="" || name.Length>=32)
  {
    throw new Exception("invalid name");
  } 
  if (age<=0 ||age>=128){
    Console.WriteLine("invalid age");
    return;
  } 
  Name=name;
  Age =age;
 }
 
 public virtual  void Print()
    {
      Console.WriteLine($"My name is {Name}, my age is {Age}");
    }

}

public class Student :  Person
{
    public int Year;
    public float Gpa;
    public Student(string name,int age,int year,float gpa ):base(name, age)
    {
        Year=year;
        Gpa=gpa; 
    }
    public override void Print()
    {
        Console.WriteLine($"my name is{Name},my age is {Age},and my gpa is{Gpa}");
    }
}
public class Stuff :Person {
    public int JoinYear;
    public double Salary;
    public Stuff(string name,int age,int joinyear,double salary ):base(name, age)
    
    {
        Salary=salary;
        JoinYear=joinyear;
    }
     public override void Print()
    {
        Console.WriteLine($"my name is{Name},my age is {Age},and my salary is{Salary}");
    }
}
public class Database{
private int _current =0;   
public Person [] Peple =new Person [50]; 
public void Addperson (Person person)
{
  // if (_current==49) return; 
   Peple[_current++]=person; 
}
public void Addstudent (Student student)
{
  // if (_current==49) return; 
   Peple[_current++]=student; 
}
public void Addstuff (Stuff stuff)
{
  // if (_current==49) return; 
   Peple[_current++]=stuff; 
}
public void PrintAll()
{
    for(var i = 0 ; i <_current; i++)
    {
        Peple[i].Print();
    }
  } 

}

public class program{
    private static void Main() 
    {
     Console.Write("enter numberfrom 1 to 4:");
     var number=Convert.ToInt32( Console.ReadLine());
     if (number==1)
     {
     var database= new Database();
     Console.Write("name:");
     var name=Console.ReadLine();
      Console.Write("age:");
     var age=Convert.ToInt32( Console.ReadLine());
      Console.Write("year:");
     var year=Convert.ToInt32( Console.ReadLine());
      Console.Write("gpa:");
     var gpa=Convert.ToSingle( Console.ReadLine());
     Student student=new Student(name,age,year,gpa);
     database.Addstudent(student);
     
     }
     else if(number==2)
     {
     var database= new Database();
     Console.Write("name:");
     var name=Console.ReadLine();
      Console.Write("age:");
     var age=Convert.ToInt32( Console.ReadLine());
      Console.Write("joinyear:");
     var joinyear=Convert.ToInt32( Console.ReadLine());
      Console.Write("slasry:");
     var salary=Convert.ToDouble( Console.ReadLine());
     var stuff=new Stuff (name,age,joinyear,salary);
     database.Addstuff(stuff);  
     }
    else if(number==3)
    {
     var database= new Database();
     Console.Write("name:");
     var name=Console.ReadLine();
      Console.Write("age:");
     var age=Convert.ToInt32( Console.ReadLine());
     var person=new Person (name,age);
     database.Addperson(person);
    }
    else 
    {
      var database= new Database();
      database.PrintAll();  
    }
}
}