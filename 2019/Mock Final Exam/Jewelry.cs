namespace Mock_Final_Exam
{
    public class Jewelry: Store
    {
        public bool DoesRepair { get; set; }
        public bool ReplaceBatteries { get; set; }

        public Jewelry(double _revenue, int _employees, string _name, string _suite, bool _repair, bool _batteries) : base(_revenue, _employees, _name, _suite)
        {
            this.DoesRepair = _repair;
            this.ReplaceBatteries = _batteries;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Performs Repair: {0}\nBattery Replacement: {1}\n", (this.DoesRepair)?"Yes":"No", (this.ReplaceBatteries)?"Yes":"No");
        }
    }
}