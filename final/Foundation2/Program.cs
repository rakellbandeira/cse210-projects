using System;

class Program
{
    static void Main(string[] args)
    {
        Product prod1 = new Product("Egg Carton", "001", 25);
        Product prod2 = new Product("Juice box", "002", 12);
        Product prod3 = new Product("Cereal Box", "003", 9);
        Product prod4 = new Product("Rice", "004", 8);
        Product prod5 = new Product("Chicken Wings", "005", 35);

        Address addressUsa = new Address("495 Aliza Ferry", "Lake Marcia", "Connecticut", "USA");
        Address adressNotInUsa = new Address("Rua Upanema, 230", "Manaus", "Amazonas", "Brazil");
        
        Customer customer1 = new Customer("Mosiah Oliveira", addressUsa);
        Customer customer2 = new Customer("Rakell Bandeira", adressNotInUsa);        

        Order order1 = new Order(customer1);
        order1.AddProduct(prod5, 2);
        order1.AddProduct(prod4, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(prod1, 2);
        order2.AddProduct(prod2, 3);
        order2.AddProduct(prod3, 4);


        //Once you have created these classes, write a program that creates at least two orders 
        // with a 2-3 products each. Call the methods to get the packing label, the shipping label,
        // and the total price of the order, and display the results of these methods.

        Console.WriteLine($"\nOrder from {customer1.GetName()}");
        order1.GetPackingLabel();
        order1.GetShippingLabel();
        Console.WriteLine($"\n\tTotal Price of the order: ${order1.TotalPrice()}");

        Console.WriteLine();
        Console.WriteLine($"\nOrder from {customer2.GetName()}");
        order2.GetPackingLabel();
        order2.GetShippingLabel();
        Console.WriteLine($"\n\tTotal Price of the order: ${order2.TotalPrice()}");

    }
}