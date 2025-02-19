namespace RealEstateInvestmentActivity
{
    public class RealEstateInvestment
    {
        private int yearBuilt;
        private double purchasePrice;
        private string streetAddress;
        private double monthlyExpense;
        private double incomeFromRent;

        public RealEstateInvestment()
        {
        }

        public RealEstateInvestment(int yearBuilt, double purchasePrice, string streetAddress)
        {
            this.yearBuilt = yearBuilt;
            this.purchasePrice = purchasePrice;
            this.streetAddress = streetAddress;
        }

        public int YearBuilt
        {
            get { return yearBuilt; }
        }
        public double PurchasePrice
        {
            get { return purchasePrice; }
        }
        public string StreetAddress
        {
            get { return streetAddress; }
        }
        public double MonthlyExpense
        {
            get { return monthlyExpense; }
            set { monthlyExpense = value; }
        }
        public double IncomeFromRent
        {
            get { return incomeFromRent; }
            set { incomeFromRent = value; }
        }

        public double DetermineMonthlyEarnings()
        {
            return incomeFromRent - monthlyExpense;
        }

    }
}