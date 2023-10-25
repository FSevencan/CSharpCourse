Customer customer = new Customer();
Student student = new Student();


customer.FirstName = "Fatih";
student.FirstName = "Ahmet";
student.Department = "Computer Science";




class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}


class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}