using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            const int TOTAL_PIZZA_SOLD = 29;
            const int SLICES_PER_PIZZA = 10;
            const double COST_PER_PIE = 11.00;
            const double STUDENT_GOV_TAX = .1;
            const double PRICE_PER_SLICE = 2.00;

            int totalSlicesSold = TOTAL_PIZZA_SOLD * SLICES_PER_PIZZA;
            double costPerSlice = COST_PER_PIE / SLICES_PER_PIZZA;
            double proceedsPerSlice = PRICE_PER_SLICE * totalSlicesSold - costPerSlice;
            double totalTaxOwed = STUDENT_GOV_TAX * proceedsPerSlice; 
            double afterTaxProfits = proceedsPerSlice - totalTaxOwed;

            Console.WriteLine("NTID Geek Club Pizza Sale Revenue");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Before-Tax Revenue:   {0:C}", proceedsPerSlice);
            Console.WriteLine("After-Tax Profits:    {0:C}", afterTaxProfits);
            Console.WriteLine("Student Gov Tax Owed: {0:C}", totalTaxOwed);

            Console.ReadLine();

        }
    }
}
