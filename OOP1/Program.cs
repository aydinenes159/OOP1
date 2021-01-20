using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.catagoryId = 2;
            product1.productName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsIdStock = 3;


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine();
    }
    }
}
