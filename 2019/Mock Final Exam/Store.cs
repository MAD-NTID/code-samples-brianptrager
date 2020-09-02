namespace Mock_Final_Exam
{
    public class Store
    {
        public double MonthlyRevenue { get; set; }
        public int NumberOfEmployees { get; set; }
        public string StoreName { get; set; }
        public string SuiteNumber { get; set; }

        public Store(double _revenue, int _employees, string _name, string _suite)
        {
            this.MonthlyRevenue = _revenue;
            this.NumberOfEmployees = _employees;
            this.StoreName = _name;
            this.SuiteNumber = SuiteNumber;
        }

        public override string ToString()
        {
            return $"\n========={this.GetType().ToString()}==========\nMonthly Revenue: {this.MonthlyRevenue}\nNumber of Employees: {this.NumberOfEmployees}\nStore Name: {this.StoreName}\nSuite Number: {this.SuiteNumber}\n";
        }

    }
}