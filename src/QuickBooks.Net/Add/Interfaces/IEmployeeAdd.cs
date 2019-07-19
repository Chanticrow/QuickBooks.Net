using QuickBooks.Net.Domain;
using System;
using System.Collections.Generic;

namespace QuickBooks.Net.Add
{
    public interface IEmployeeAdd
    {
        IEmployeeAdd IsActive(bool isActive);
        IEmployeeAdd Salutation(string salutation);
        IEmployeeAdd FirstName(string firstName);
        IEmployeeAdd MiddleName(string middleName);
        IEmployeeAdd LastName(string lastName);
        IEmployeeAdd JobTitle(string jobTitle);
        IEmployeeAdd Department(string department);
        IEmployeeAdd Description(string description);
        IEmployeeAdd EmployeeAddress(Address billAddress);
        IEmployeeAdd PrintAs(string printAs);
        IEmployeeAdd Phone(string phone);
        IEmployeeAdd Mobile(string mobile);
        IEmployeeAdd Pager(string pager);
        IEmployeeAdd PagerPIN(string pagerPin);
        IEmployeeAdd AltPhone(string altPhone);
        IEmployeeAdd Fax(string fax);
        IEmployeeAdd SSN(string ssn);
        IEmployeeAdd Email(string email);
        IEmployeeAdd AdditionalContactRef(List<AdditionalContactRef> additionalContactRefs);
        IEmployeeAdd EmployeeType(string employeeType);
        IEmployeeAdd PartOrFullTime(string partOrFullTime);
        IEmployeeAdd Exempt(string exempt);
        IEmployeeAdd KeyEmployee(string keyEmployee);
        IEmployeeAdd Gender(string gender);
        IEmployeeAdd HiredDate(DateTime hiredDate);
        IEmployeeAdd OriginalHireDate(DateTime originalHireDate);
        IEmployeeAdd AdjustedServiceDate(DateTime adjustedServiceDate);
        IEmployeeAdd ReleasedDate(DateTime releasedDate);
        IEmployeeAdd BirthDate(DateTime birthDate);
        IEmployeeAdd USCitizen(string usCitizen);
        IEmployeeAdd Ethnicity(string ethnicity);
        IEmployeeAdd Disabled(string disabled);
        IEmployeeAdd DisabilityDesc(string disabilityDesc);
        IEmployeeAdd OnFile(string onFile);
        IEmployeeAdd WorkAuthExpireDate(DateTime workAuthExpireDate);
        IEmployeeAdd USVeteran(string usVeteran);
        IEmployeeAdd MilitaryStatus(string miltaryStatus);
        IEmployeeAdd AccountNumber(string accountNumber);
        IEmployeeAdd Notes(string notes);
        IEmployeeAdd IncludeRetElement(params string[] retElements);
        IEmployeeAdd FromDomainObject(Employee employee);
        IEmployeeAdd FromDomainObject(Employee employee, bool neglectReferences);
        Employee Add();
    }
}
