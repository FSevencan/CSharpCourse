

using İnterfaces;

PersonManger manager = new PersonManger();
manager.Add(new Customer { Id = 1, FirstName = "Fatih", LastName = "Sevencan", Adress = "Istanbul" });

CustomerManger customerManger = new CustomerManger();
customerManger.Add(new SqlServerCustomerDal());

//-----------------------------------------------------
ICustomerDal[] customerDals = new ICustomerDal[2]
    {
        new SqlServerCustomerDal(),
        new OracleCustomerDal()
    };

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}
// ------------------------------------------------------



Student Student = new Student()
{
    Id = 1,
    FirstName = "Ahmet",
    LastName = "Korkmaz",
    Departmant = "Computer Sciences"
};



interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }



}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Adress { get; set; }

}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Departmant { get; set; }
}

class PersonManger
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}