using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace QuickBooks.Net.Domain
{
    [XmlRoot("EmployeeRet")]
    public class Employee : EntityBase
    {
        public Employee()
            : base("Employee")
        { }

        public virtual string Department { get; set; }
        public virtual string Description { get; set; }
        public virtual Address EmployeeAddress { get; set; }
        public virtual string PrintAs { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string Pager { get; set; }
        public virtual string PagerPIN { get; set; }
        public virtual string SSN { get; set; }
        [XmlElement("AdditionalContactRef")]
        public virtual List<AdditionalContactRef> AdditionalContactRef { get; set; }
        public virtual string EmployeeType { get; set; }
        public virtual string PartOrFullTime { get; set; }
        public virtual string Exempt { get; set; }
        public virtual string KeyEmployee { get; set; }
        public virtual string Gender { get; set; }
        public virtual DateTime HiredDate { get; set; }
        public virtual DateTime OriginalHireDate { get; set; }
        public virtual DateTime AdjustedServiceDate { get; set; }
        public virtual DateTime ReleasedDate { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual string USCitizen { get; set; }
        public virtual string Ethnicity { get; set; }
        public virtual string Disabled { get; set; }
        public virtual string DisabilityDesc { get; set; }
        public virtual string OnFile { get; set; }
        public virtual DateTime WorkAuthExpireDate { get; set; }
        public virtual string USVeteran { get; set; }
        public virtual string MilitaryStatus { get; set; }
        public virtual Reference BillingRateRef { get; set; }
    }
}
