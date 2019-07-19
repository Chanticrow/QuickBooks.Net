namespace QuickBooks.Net.Domain
{
    public class AdditionalContactRefType
    {
        private AdditionalContactRefType(string value) { Value = value; }
        public string Value { get; set; }

        public static AdditionalContactRefType Main_Phone { get { return new AdditionalContactRefType("Main Phone"); } }
        public static AdditionalContactRefType Home_Phone { get { return new AdditionalContactRefType("Home Phone"); } }
        public static AdditionalContactRefType Work_Phone { get { return new AdditionalContactRefType("Work Phone"); } }
        public static AdditionalContactRefType Mobile { get { return new AdditionalContactRefType("Mobile"); } }
        public static AdditionalContactRefType Fax { get { return new AdditionalContactRefType("Fax"); } }
        public static AdditionalContactRefType Alt_Phone { get { return new AdditionalContactRefType("Alt. Phone"); } }
        public static AdditionalContactRefType Alt_Mobile { get { return new AdditionalContactRefType("Alt. Mobile"); } }
        public static AdditionalContactRefType Alt_Fax { get { return new AdditionalContactRefType("Alt. Fax"); } }
        public static AdditionalContactRefType Main_Email { get { return new AdditionalContactRefType("Main Email"); } }
        public static AdditionalContactRefType Cc_Email { get { return new AdditionalContactRefType("CC Email"); } }
        public static AdditionalContactRefType Alt_Email1 { get { return new AdditionalContactRefType("Alt. Email 1"); } }
        public static AdditionalContactRefType Alt_Email2 { get { return new AdditionalContactRefType("Alt. Email 2"); } }
        public static AdditionalContactRefType Website { get { return new AdditionalContactRefType("Website"); } }
        public static AdditionalContactRefType LinkedIn { get { return new AdditionalContactRefType("LinkedIn"); } }
        public static AdditionalContactRefType Facebook { get { return new AdditionalContactRefType("Facebook"); } }
        public static AdditionalContactRefType Twitter { get { return new AdditionalContactRefType("Twitter"); } }
        public static AdditionalContactRefType Url1 { get { return new AdditionalContactRefType("URL1"); } }
        public static AdditionalContactRefType Url2 { get { return new AdditionalContactRefType("URL2"); } }
        public static AdditionalContactRefType Url3 { get { return new AdditionalContactRefType("URL3"); } }
        public static AdditionalContactRefType Url4 { get { return new AdditionalContactRefType("URL4"); } }
        public static AdditionalContactRefType Skype_Id { get { return new AdditionalContactRefType("Skype ID"); } }
        public static AdditionalContactRefType Other1 { get { return new AdditionalContactRefType("Other 1"); } }
        public static AdditionalContactRefType Other2 { get { return new AdditionalContactRefType("Other 2"); } }
        public static AdditionalContactRefType Other3 { get { return new AdditionalContactRefType("Other 3"); } }

    }
}
