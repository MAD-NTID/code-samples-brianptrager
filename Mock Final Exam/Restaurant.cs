namespace Mock_Final_Exam
{
    public class Restaurant : Store
    {
        public string Type { get; set; }
        public bool FullService { get; set; }

        public Restaurant(double _revenue, int _employees, string _name, string _suite, string _type, bool _service) : base(_revenue, _employees, _name, _suite)
        {
            this.Type = _type;
            this.FullService = _service;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Type: {0}\nFull Service: {1}\n ", this.Type, (this.FullService)?"Yes":"No");
        }
    }
}