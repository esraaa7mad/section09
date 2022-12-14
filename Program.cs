using System;
public abstract class Person{
 public string Name;
 public int Age;
 public Person(string name,int age){
  Name=name;
  Age =age;
 }
 public abstract void print ();

}

public class Student :  Person{
    public int Year;
    public float Gpa;
    public Student(string name,int age,int year,float gpa ):base(name, age){
        Year=year;
        Gpa=gpa; 
    }
    public override void print()
    {
        Console.WriteLine($"my name is{Name},my age is {Age},and my gpa is{Gpa}");
    }
}
public class Database{
private int _current =0;   
public Person [] Peple =new Person [50]; 
public void Addstudent (Student student){
  // if (_current==49) return; 
   Peple[_current++]=student; 
}

}
public class program{
    private static void Main() {
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
    // Console.WriteLine("Hello, World!");
}
}