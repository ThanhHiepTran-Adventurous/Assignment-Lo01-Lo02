using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace AssBillManagement;

public class Customer
{
    Customer[] customerList = new Customer[100];
    public int customerID { get; set; }

    public string customerName { get; set; }

    public string customerAddress { get; set; }

    public float quantity { get; set; }

    public float unitPrice { get; set; }

    public Customer()
    {
        customerID = 0;
        customerName = "";
        customerAddress = "";
        quantity = 0;
        unitPrice = 0;
    }

    public Customer(int customerID, string customerName, string customerAddress, float quantity, float unitPrice)
    {
        this.customerID = customerID;
        this.customerName = customerName;
        this.customerAddress = customerAddress;
        this.quantity = quantity;
        this.unitPrice = unitPrice;
    }




    //public bool findid(int cusid)
    //{
    //    for (int i = 0; i < customerlist.length; i++)
    //    {
    //        if (customerlist.get.equals(cusid))
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}




    public void InputData()
    {
        ConsoleColor foreground = Console.ForegroundColor;
       
        //ConsoleColor background = Console.BackgroundColor;
        //Console.BackgroundColor = ConsoleColor.Red;
        int count = 0;
        do
        {
            try
            {
                count = 0;
                String pattern = "^[A-Z._%+-]+@[A-Z.-]+\\.[A-Z]{}$";
                Console.Write($"Customer ID: ");
                this.customerID = Convert.ToInt32(Console.ReadLine());
                if (this.customerID.Equals(pattern))
                {
                    throw new Exception();
                }
              
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Don't type a character!!!!!");
                count++;
            }
            Console.ResetColor();

        } while (count != 0);

        do
        {
            try
            {
                count = 0;
                String pattern = "[0-9]";
                Console.Write($"Customer Name: ");
                this.customerName = Console.ReadLine();
                if(Regex.IsMatch(this.customerName, pattern))
                {
                    throw new Exception();
                }

            }catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Don't type a number");
                count++;
            }
            Console.ResetColor();

        } while (count != 0);

        do
        {
            try
            {
                count = 0;
                String pattern = "[0-9]";
                Console.Write($"Address: ");
                this.customerAddress = Console.ReadLine();
                if (Regex.IsMatch(this.customerAddress, pattern))
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Don't type a number");
                count++;
            }
            Console.ResetColor();

        } while (count != 0);


        do
        {
            try
            {
                count = 0;
                String pattern = "^[A-Z._%+-]+@[A-Z.-]+\\.[A-Z]{}$";
                Console.Write($"Quantity: ");
                this.quantity = float.Parse(Console.ReadLine());
                if (this.quantity.Equals(pattern))
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Don't type a character!!!!!");
                count++;
            }
            Console.ResetColor();

        } while (count != 0);

        do
        {
            try
            {
                count = 0;
                String pattern = "^[A-Z._%+-]+@[A-Z.-]+\\.[A-Z]{}$";
                Console.Write($"Unit Price: ");
                this.unitPrice = float.Parse(Console.ReadLine());
                if (this.unitPrice.Equals(pattern))
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Don't type a character!!!!!");
                count++;
            }
            Console.ResetColor();

        } while (count != 0);
    }
   
}
