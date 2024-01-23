

Person person1=new Person();
person1.Firstname="Shahrom";
person1.Lastname="Sharipov";
person1.Age=2000;
System.Console.WriteLine(person1.GetFullName());
System.Console.WriteLine(person1.GetBirthYear());


public class Person
{
    public string Firstname;
    public string Lastname;
    public int Age;
    public string Address;



    public string GetFullName()
    {
        return $"My name is {Firstname} {Lastname}";
    }
    public string GetBirthYear()
    {
        return $"My birth year is {Age}";
    }

}