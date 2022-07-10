using System;
namespace AssBillManagement;
using System.Collections;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int choice = 0;
        CustomerList list = new CustomerList();
        do
        {
            Console.Clear();
            Console.WriteLine($"|============================$ Menu $=========================================|");
            Console.WriteLine($"|=============================================================================|");       
            Console.WriteLine($"|        1. Input the transaction for Vietnam Customer                        |");
            Console.WriteLine($"|        2. Input the transaction for Foreigner Customer                      |");
            Console.WriteLine($"|        3. Export a list of bill                                             |");
            Console.WriteLine($"|        4. Calculate the total amount of KW for type of customer             |");
            Console.WriteLine($"|        5. Calculate the average of total bill for Foreigner Customer        |");
            Console.WriteLine($"|        0. Exit                                                              |");
            Console.WriteLine($"|=============================================================================|");
            
            do
            {
                try
                {
                    count = 0;
                    String pattern = "^[A-Z._%+-]+@[A-Z.-]+\\.[A-Z]{}$";
                    Console.Write("         Please choose the function: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice.Equals(pattern))
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please Don't type a character. You need to choose option on the menu by number!!!!!");
                    count++;
                }

            } while (count != 0);
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    list.inputCustomerList(1);
                    break;
                case 2:
                    Console.Clear();
                    list.inputCustomerList(2);
                    break ;
                case 3:
                    Console.Clear();
                    list.displayExportTheListCustomer();
                    break;
                case 4:
                    Console.Clear();
                    list.calculateTotalAmountOfConsumption();
                    break;
                case 5:
                    Console.Clear();
                    list.TheAverageOfForeigner();
                    break;
            }
        } while(choice != 0);
    }
}