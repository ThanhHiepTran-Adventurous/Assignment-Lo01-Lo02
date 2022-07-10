using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssBillManagement;

public class CustomerList
{

    Customer[] customerList = new Customer[100];

    private VietnamCustomer listVietnamCustomer;
    private ForeignerCustomer listForeignerCustomer;
    

    private int count;
    private float totalAmountConsumedVnCus, totalAmountConsumedFrgnCus;

    private double averageTotalBill;


    public CustomerList ()
    {
        count = 0;
        totalAmountConsumedVnCus = 0;
        totalAmountConsumedFrgnCus = 0;
        averageTotalBill = 0;
        for(int i = 0; i < customerList.Length; i++)
        {
            customerList[i] = new Customer();
            averageTotalBill = i++;
        }

    }

    //NHập dữ liệu cho từng loại khác hàng

    public void inputCustomerList(byte check)
    {
        if(count > 100)
        {
            Console.WriteLine("Error!!");
        }
        else
        {
            if(check == 1)
            {
                customerList[count] = new VietnamCustomer();
                listVietnamCustomer = new VietnamCustomer();
                listVietnamCustomer.inputForVietnamCustomer();
                totalAmountConsumedVnCus += listVietnamCustomer.quantity;

                customerList[count] = listVietnamCustomer;
                count++;

            }
            else
            {
                customerList[count] = new ForeignerCustomer();

                listForeignerCustomer = new ForeignerCustomer();
                listForeignerCustomer.inputForForeignerCustomer();
                totalAmountConsumedFrgnCus += listForeignerCustomer.quantity;

                customerList[count] = listForeignerCustomer;
                count++;
            }
        }
    }


    //----------------------------------------------------------------------
    // Hàm tính tổng số lượng KW tiêu thụ cho từng loại khách hàng
    public void calculateTotalAmountOfConsumption()
    {
        Console.WriteLine($"=================> Total amount of consumption for Vietnam Customer: " + totalAmountConsumedVnCus);
        Console.WriteLine($"=================> Total amount of consumption for Foreigner Customer: " + totalAmountConsumedFrgnCus);
        Console.ReadLine();
    }


    //-----------------------------------------------------------------------
    //Tính trung bình thành tiền của khách hàng người nước ngoài.
    public void TheAverageOfForeigner()
    {
       
                // double totalAmount = (listForeignerCustomer.totalBill) / 2;
                // averageTotalBill = totalAmount;
                Console.WriteLine($"The average of total bill for Foreigner Customer: " + averageTotalBill/totalAmountConsumedFrgnCus);
                Console.ReadKey();
                      
      
    }
    //----------------------------------------------
    // Xuất các danh sách hóa đơn của khách hàng
    public void displayExportTheListCustomer()
    {
        if(count == 0)
        {
            Console.WriteLine("No data exists yet");
            Console.ReadKey();
        }else
        {
            for(int i = 0; i < count; i++)
            {
              // Console.WriteLine("~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$");
                Console.WriteLine("                     Transaction number {0}", i + 1);
                if (customerList[i].GetType() == typeof(VietnamCustomer))
                {
                    listVietnamCustomer = (VietnamCustomer) customerList[i];
                    listVietnamCustomer.displayInVietnam();
                }
                else
                {
                    listForeignerCustomer = (ForeignerCustomer) customerList[i];
                    listForeignerCustomer.displayForeigner();
                }
                Console.WriteLine("~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$");
            }
            Console.ReadKey();
        }
    }
}
