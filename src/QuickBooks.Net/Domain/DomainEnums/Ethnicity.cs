namespace QuickBooks.Net.Domain
{
    public class Ethnicity
    {
        private Ethnicity(string value) { Value = value; }
        public string Value { get; set; }

        public static Ethnicity American_Indian_Alaskan_Native { get { return new Ethnicity("AmericanIndian"); } }
        public static Ethnicity Asian { get { return new Ethnicity("Asian"); } }
        public static Ethnicity Black_African_American { get { return new Ethnicity("Black"); } }
        public static Ethnicity Hawaiian_Pacific_Islander { get { return new Ethnicity("Hawaiian"); } }
        public static Ethnicity Hispanic_Latino { get { return new Ethnicity("Hispanic"); } }
        public static Ethnicity White { get { return new Ethnicity("White"); } }
        public static Ethnicity Two_Or_More_Races { get { return new Ethnicity("TwoOrMoreRaces"); } }
        public static Ethnicity No_Answer { get { return new Ethnicity(""); } }
    }
}
