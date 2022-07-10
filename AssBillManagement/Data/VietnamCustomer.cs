using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace AssBillManagement;

public class VietnamCustomer : Customer
{
    public string typeCustomer { get; set; }

    public float quota { get; set; }

    public double totalBill { get; set; }

    public VietnamCustomer()
    {
    }

    public VietnamCustomer(int customerID, string customerName, string customerAddress, float quantity, float unitPrice, string type, float quota) : 
        base(customerID, customerName, customerAddress, quantity, unitPrice)
    {
        this.typeCustomer = type;
        this.quota = quota;
    }




    //----------------------------------------------------------------------------
    public bool isType(String typeCus)
    {
        if(Regex.IsMatch(typeCus, "L|B|M"))
        {
            return true;
        }
        return false;
        
    }

    public String convertType(String typeCus)
    {
        if (isType(typeCus))
        {
            if (typeCus.Equals("L"))
            {
                return "Living";
            }else if (typeCus.Equals("B"))
            {
                return "Buisiness";
            }else if(typeCus.Equals("M"))
            {
                return "Manufacturing";
            }
        }
        return typeCus;
    }



    public void inputForVietnamCustomer()
    {
        int count = 0;
        base.InputData();
        bool cont =  true;
        do
        {
            try
            {
                count = 0;
                String pattern = "[0-9]";
                Console.Write($"Customer Type(Living or Buisiness or Manufacturing). Please type L or B or M: ");
                this.typeCustomer = Console.ReadLine();
              //  String typeCus = this.typeCustomer;
                this.typeCustomer = convertType(this.typeCustomer);
                if (Regex.IsMatch(this.typeCustomer, pattern))
                {
                    throw new Exception();
                }
                if (this.typeCustomer.Equals("Living"))
                {
                    this.typeCustomer = "Living";
                    cont = false;
                }else if(this.typeCustomer.Equals("Buisiness"))
                {
                    this.typeCustomer = "Buisiness";
                    cont = false;
                }else if(this.typeCustomer.Equals("Manufacturing"))
                {
                    this.typeCustomer = "Manufacturing";
                    cont = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
               // count++;
                cont = true;
            }

        } while (cont);

        do
        {
            try
            {
                count = 0;
                String pattern = "^[A-Z._%+-]+@[A-Z.-]+\\.[A-Z]{}$";
                Console.Write($"Input Quota: ");
                this.quota = float.Parse(Console.ReadLine());
                if (this.quota.Equals(pattern))
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Don't type a character!!!!!");
                count++;
            }

        } while (count != 0);

        if(quantity <= quota)
        {
            this.totalBill = quantity * unitPrice;
        }else
        {
            this.totalBill = quantity * unitPrice * quota + (quantity - quota) * unitPrice * 2.5;

        }
    }


    public void displayInVietnam()
    {
        // Console.WriteLine("~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$");
        Console.WriteLine($"                     Customer ID: " + customerID                                    );
        Console.WriteLine($"                     Customer Name: " + customerName                                );
        Console.WriteLine($"                     Address: " + customerAddress                                   );
        Console.WriteLine($"                     Customer Type: " + typeCustomer                                );
        Console.WriteLine($"                     Amount of consumption: " + quantity                            );
        Console.WriteLine($"                     Unit Price: " + unitPrice                                      ); 
        Console.WriteLine($"                     Quota: " + quota                                               );
        Console.WriteLine($"                     Bill Total: " + totalBill                                      );
        Console.WriteLine("~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$");
    }

}

