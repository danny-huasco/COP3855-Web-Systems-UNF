

namespace RealEstateInvestmentActivity
{
    public class PropertyApp
    {
        private static RealEstateInvestment invest1;
        const double RENTAL_AMOUNT = 1000.00;

        public static void Main()
        {
            //assign values to the constructor
            int year = 2004;
            double price = 150000;
            string address = "65th Street";
            //call constructor of R.E.I class
            invest1 = new RealEstateInvestment(year, price, address);
            //set values to Monthly expenses using method GetExpenses()
            invest1.MonthlyExpense = GetExpenses();
            //set value to income using constant
            invest1.IncomeFromRent = RENTAL_AMOUNT;
            //print data: property location
            Console.WriteLine("Property address: {0}\n", invest1.StreetAddress);
            //print data: earnings per month
            Console.WriteLine("Earnings per month: {0:F2}\n", invest1.DetermineMonthlyEarnings());
        }

        public static double GetExpenses()
        {
            double insurance, taxes, utilities;
            Console.WriteLine("Enter the insurance rate: \n");
            insurance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the tax amount: \n");
            taxes = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter utilities amount: \n");
            utilities = double.Parse(Console.ReadLine());

            return (insurance/12)+(taxes/12)+utilities;
        }


    }
}
