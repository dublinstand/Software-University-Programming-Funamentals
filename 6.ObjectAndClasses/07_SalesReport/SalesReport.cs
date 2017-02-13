using System;
using System.Collections.Generic;
using System.Linq;

//Write a class Sale holding the following data: town, product, price, quantity.
//Read a list of sales and calculate and print the total sales by town as shown in the output.Order alphabetically the towns in the output.

class SalesReport
{
    static void Main()
    {
        Sale[] sales = Sale.ReadSales();

        //int n = int.Parse(Console.ReadLine());
        //List<Sale> sales2 = new List<Sale>();
        //for (int i = 0; i < n; i++)
        //{
        //    Sale sale2 = Sale.ReadSale();
        //    sales2.Add(sale2);
        //}

        //Console.WriteLine(sales.Sum(s => s.quantity));

        //Map Sale --> string (towns)
        var towns = sales.Select(s => s.town).OrderBy(t => t).Distinct().ToArray();
        //Console.WriteLine(string.Join(" ", towns));

        foreach (var t in towns)
        {
            var salesForT = sales.Where(s => s.town == t).Sum(s => s.price * s.quantity);
            Console.WriteLine("{0} -> {1:f2}", t, salesForT);
        }
    }
}

class Sale
{
    public String town { get; set; }
    public String product { get; set; }
    public decimal price { get; set; }
    public decimal quantity { get; set; }

    public static Sale ReadSale()
    {
        string[] token = Console.ReadLine().Split(' ').ToArray();
        //Sale sale = new Sale();

        //sale.town = token[0];
        //sale.product = token[1];
        //sale.price = decimal.Parse(token[2]);
        //sale.quantity= decimal.Parse(token[3]);

        //return sale;

        return new Sale()
        {
            town = token[0],
            product = token[1],
            price = decimal.Parse(token[2]),
            quantity = decimal.Parse(token[3])
        };

    }

    public static Sale[] ReadSales()
    {
        int n = int.Parse(Console.ReadLine());
        Sale[] sales = new Sale[n];

        for (int i = 0; i < n; i++)
        {
            sales[i] = Sale.ReadSale();
        }

        return sales;
    }

}

