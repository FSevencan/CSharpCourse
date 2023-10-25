
using Classes;

Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Fatih";
customer.LastName = "Sevencan";
customer.City = "İstanbul";

Customer customer2 = new Customer
{
    Id = 2, City = "Ankara", FirstName = "Mert", LastName = "Korkmaz"
};


Console.WriteLine(customer2.FirstName);

CustomerManager customerManager = new CustomerManager();

customerManager.Add();
customerManager.Update();


ProductManager productManager = new ProductManager();

productManager.Add();
productManager.Update();

class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added");
    }

    public void Update()
    {
        Console.WriteLine("Customer Updated!");
    }


}

class ProductManager
{
    public void Add()
    {
        Console.WriteLine("Product Added");
    }

    public void Update()
    {
        Console.WriteLine("Product Updated!");
    }


}