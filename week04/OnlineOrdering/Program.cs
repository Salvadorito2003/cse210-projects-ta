using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.SetCustomerInformation("Peter Smith", "435 Silva Street", "Pergamino", "Buenos Aires", "Argentina");
        order1.AddProduct("Table", "55-465", "25.50", "2");
        order1.AddProduct("Chair", "55-573", "8.50", "8");
        order1.AddProduct("Cabinet", "34-582", "20.00", "2");

        Order order2 = new Order();
        order2.SetCustomerInformation("Jeffrey Banks", "122 North Street", "Provo", "Utah", "USA");
        order2.AddProduct("Desk", "51-335", "20.50", "1");
        order2.AddProduct("Chair", "55-573", "8.50", "2");
        order2.AddProduct("Computer", "14-238", "50.00", "1");

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        List<string> packingLabel1 = order1.GetPackingLabel();
        foreach (string p in packingLabel1)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine("----------------");
        Console.WriteLine($"${order1.CalculateFinalPrice()}");
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        List<string> packingLabel2 = order2.GetPackingLabel();
        foreach (string p in packingLabel2)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine("----------------");
        Console.WriteLine($"${order2.CalculateFinalPrice()}");
        Console.WriteLine();
    }
}