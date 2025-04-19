Person person = new Person();
Employee employee = new Employee();
Customer customer = new Customer();

// or use the following lines to create instances

//Person person = new Person();
//Person employee = new Employee();
//Person customer = new Customer();

person.Greeting();
employee.Greeting();
customer.Greeting();

public class Person
{
    public virtual void Greeting()
    {
        Console.WriteLine("Hello, I am a regular person.");
    }
}

public class Employee : Person
{
    public override void Greeting()
    {
        Console.WriteLine("Hello, I am an employee.");
    }
}

public class Customer : Person
{
    public override void Greeting()
    {
        Console.WriteLine("Hello, I am a customer.");
    }
}