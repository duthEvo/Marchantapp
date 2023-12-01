// See https://aka.ms/new-console-template for more information

#region jewelary discount customer project

using static Goldmerchant.Program;

namespace Goldmerchant
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter gold customer details");
            Goldcustomer customer = new Goldcustomer();
            Console.WriteLine("enter customer id");
            customer.CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer name");
            customer.CustomerName = Console.ReadLine();
            Console.WriteLine("enter product name");
            customer.ProductName = Console.ReadLine();
            Console.WriteLine("enter product amount");
            customer.ProductAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Print the discount amount");

            customer.Customerdiscount();

            //Console.WriteLine("please enter silver customer details");

            //Silvercustomer customer2 = new Silvercustomer();
            //Console.WriteLine("enter customer id");
            //customer2.CustomerId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter customer name");
            //customer2.CustomerName = Console.ReadLine();
            //Console.WriteLine("enter product name");
            //customer2.ProductName = Console.ReadLine();
            //Console.WriteLine("enter product amount");
            //customer2.ProductAmount = Convert.ToDecimal(Console.ReadLine());
            //customer2.Customerdiscount();

        }

    }

    interface ICustomer
    {
        int CustomerId { get; set; }
        string CustomerName { get; set; }
        string ProductName { get; set; }

        decimal ProductAmount { get; set; }

        decimal Customerdiscount();
    }
    public abstract class Customer : ICustomer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? ProductName { get; set; }
        public decimal ProductAmount { get; set; }

        //further development purpsse to create making charge based on current price.
        //public decimal productweight { get; set; }

        //public decimal inputweight { get; set; }

        public abstract decimal Customerdiscount();


    }

    public class Goldcustomer : Customer, ICustomer
    {
        // for all silver item 3% discount 
        // for all silver items 8 - 12 % making charge on raw weight as per product design product

        //public decimal productWeight { get; set; }

        //decimal discount = Console.WriteLine("{0}/{1}", ProductAmount, 100);
        public override decimal Customerdiscount()
        {

            // return discount * 3;
            return (ProductAmount / 100) * 8;
            // estimated discount amount for this item = 2434/100 * 8 = 2239

        }
    }
    public class Silvercustomer : Customer, ICustomer
    {

        //decimal discount = Console.WriteLine("{0}/{1}", ProductAmount, 100);
        public override decimal Customerdiscount()
        {
            // for all silver item 10% discount 
            // for all silver items 8% making charge on raw weight of product


            return (ProductAmount / 100) * 3;
            //Console.WriteLine("{0}/{1}", ProductAmount, 100);
            // estimated discount amount for this item = 2434/100 * 8 = 2239
        }

    }
    //further development purpsse to create making charge based on current price.

    //private class makingcharge
    //{
    //    Console.WriteLine("{0}-{1}",)


    //}


}

#endregion