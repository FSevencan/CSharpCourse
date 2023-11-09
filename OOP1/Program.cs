

using OOP1;

Product product1  = new Product();

product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitInStock = 500;
product1.UnitInStock = 3;


ProductManager productManager = new ProductManager();

productManager.Add(product1);
Console.WriteLine(product1.ProductName);