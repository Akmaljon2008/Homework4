Person person1 = new Person();
Console.Write("Enter your FirstName : ");
person1.FirstName = Console.ReadLine();
Console.Write("Enter your LastName : ");
person1.LastName = Console.ReadLine();
Console.Write("Enter your Age : ");
person1.Age = int.Parse(Console.ReadLine());

System.Console.Write(person1.Getinfo());

class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
     
    public string Getinfo()
    {
         return $"FirstName : {this.FirstName},\nLastName : {this.LastName},\nAge : {this.Age}";
    }
}