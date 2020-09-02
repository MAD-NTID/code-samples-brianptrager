namespace Mock_Final_Exam
{
    public class Clothing : Store
    {
        public string ClothingStyle { get; set; }

        public Clothing(double _revenue, int _employees, string _name, string _suite, string _style) : base(_revenue, _employees, _name, _suite)
        {
            this.ClothingStyle = _style;
        }

        public override string ToString()
        {
            return base.ToString() + $"Clothing Style: {this.ClothingStyle}\n";
        }
    }
}