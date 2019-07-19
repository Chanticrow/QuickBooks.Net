namespace QuickBooks.Net.Domain
{
    public class EmployeeType
    {
        private EmployeeType(string value) { Value = value; }
        public string Value { get; set; }

        public static EmployeeType Regular { get { return new EmployeeType("Regular"); } }
        public static EmployeeType Office { get { return new EmployeeType("Office"); } }
        public static EmployeeType Statutory { get { return new EmployeeType("Statutory"); } }
        public static EmployeeType Owner { get { return new EmployeeType("Owner"); } }
    }
}
