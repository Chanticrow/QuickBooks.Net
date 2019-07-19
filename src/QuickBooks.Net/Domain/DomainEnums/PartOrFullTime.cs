using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBooks.Net.Domain
{
    public class PartOrFullTime
    {
        private PartOrFullTime(string value) { Value = value; }
        public string Value { get; set; }

        public static PartOrFullTime Full_Time { get { return new PartOrFullTime("FullTime"); } }
        public static PartOrFullTime Part_Time { get { return new PartOrFullTime("PartTime"); } }
    }
}
