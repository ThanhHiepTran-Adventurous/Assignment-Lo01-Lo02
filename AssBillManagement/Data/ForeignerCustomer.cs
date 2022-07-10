using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AssBillManagement;
using System.Text.RegularExpressions;
public class ForeignerCustomer : Customer
{
    public string nationality { get; set; }

    public double totalBill { get; set; }

    public ForeignerCustomer()
    {
    }

    public ForeignerCustomer(int customerID, string customerName, string customerAddress, float quantity, float unitPrice, string nationality) :
        base(customerID, customerName, customerAddress, quantity, unitPrice)
    {
        this.nationality = nationality;
    }

    public void inputForForeignerCustomer()
    {

        int count = 0;

        base.InputData();
        do
        {
            try
            {
                count = 0;
                String pattern = "[0-9]";
                Console.Write($"Nationality: ");
                this.nationality = Console.ReadLine();
                if (Regex.IsMatch(this.nationality, pattern))
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Don't type a number");
                count++;
            }


        } while (count != 0);

        // tính hóa đơn cho người nước ngoài
        totalBill = quantity * unitPrice;
    }

    public void displayForeigner()
    {
        Console.WriteLine("~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$");
        Console.WriteLine($"                        Customer ID: " + customerID)                                 ;
        Console.WriteLine($"                        Customer Name: " + customerName)                             ;
        Console.WriteLine($"                        Address: " + customerAddress)                                ;
        Console.WriteLine($"                        Nationaly: " + nationality)                                  ;   
        Console.WriteLine($"                        Amount of consumption: " + quantity)                         ;
        Console.WriteLine($"                        Unit Price: " + unitPrice)                                   ;      
        Console.WriteLine($"                        Bill Total: " + totalBill)                                   ;
        Console.WriteLine("~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$");
    }
}

