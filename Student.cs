using System.Globalization;
using System.Security.Cryptography.X509Certificates;

internal class Student
{
    public string Name;
    public string Surname;
    public string Group;
    public double Point;
    public bool isGraduated;

    public Student()

    {


    }
    public Student(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
        
    }
    public Student(bool isGraduate)
    {
       this.isGraduated = isGraduate;
    }
    public Student(string name, string surname, string group, bool isGraduate, double point):this(isGraduate) 
  {
        this.Name = name;
        this.Surname = surname;
        this.Group = group;
        this.Point = point;
    }


    public void NameandSurname()
    {
        Console.WriteLine(this.Name + " " + this.Surname);

    }


    public bool NextExam()

    {
        if (this.isGraduated)
        {
        isGraduated = true;
            return this.Point > 80;
        }
        return this.Point < 0;
    }



    public void GetFullInfo()
    {
        Console.WriteLine(this.Name + " " + this.Surname + " " + this.Group + " " + this.Point + " " + this.isGraduated);


        if (Point > 100 || Point < 0)
        {
            Console.WriteLine("Failed");
        }
        else if (Point > 80)
        {
            Console.WriteLine("second exam allowed");
        }
        else if (Point >= 0 && Point <= 80)
        {
            Console.WriteLine("second exam not allowed");
        }
          
    
    
    }


    }


