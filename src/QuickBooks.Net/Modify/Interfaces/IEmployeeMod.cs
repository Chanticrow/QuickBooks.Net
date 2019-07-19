using System;
using System.Collections.Generic;
using QuickBooks.Net.Domain;

namespace QuickBooks.Net.Modify
{
    public interface IEmployeeMod
    {
        IEmployeeMod ListID(string listId);
        IEmployeeMod EditSequence(string editSequence);
        IEmployeeMod IsActive(bool isActive);
        IEmployeeMod Salutation(string salutation);
        IEmployeeMod FirstName(string firstName);
        IEmployeeMod MiddleName(string middleName);
        IEmployeeMod LastName(string lastName);
        IEmployeeMod JobTitle(string jobTitle);
        IEmployeeMod Department(string department);
        IEmployeeMod Description(string description);
        IEmployeeMod EmployeeAddress(Address billAddress);
        IEmployeeMod PrintAs(string printAs);
        IEmployeeMod Phone(string phone);
        IEmployeeMod Mobile(string mobile);
        IEmployeeMod Pager(string pager);
        IEmployeeMod PagerPIN(string pagerPin);
        IEmployeeMod AltPhone(string altPhone);
        IEmployeeMod Fax(string fax);
        IEmployeeMod SSN(string ssn);
        IEmployeeMod Email(string email);
        IEmployeeMod AdditionalContactRef(List<AdditionalContactRef> additionalContactRefs);
        IEmployeeMod EmployeeType(string employeeType);
        IEmployeeMod PartOrFullTime(string partOrFullTime);
        IEmployeeMod Exempt(string exempt);
        IEmployeeMod KeyEmployee(string keyEmployee);
        IEmployeeMod Gender(string gender);
        IEmployeeMod HiredDate(DateTime hiredDate);
        IEmployeeMod OriginalHireDate(DateTime originalHireDate);
        IEmployeeMod AdjustedServiceDate(DateTime adjustedServiceDate);
        IEmployeeMod ReleasedDate(DateTime releasedDate);
        IEmployeeMod BirthDate(DateTime birthDate);
        IEmployeeMod USCitizen(string usCitizen);
        IEmployeeMod Ethnicity(string ethnicity);
        IEmployeeMod Disabled(string disabled);
        IEmployeeMod DisabilityDesc(string disabilityDesc);
        IEmployeeMod OnFile(string onFile);
        IEmployeeMod WorkAuthExpireDate(DateTime workAuthExpireDate);
        IEmployeeMod USVeteran(string usVeteran);
        IEmployeeMod MilitaryStatus(string miltaryStatus);
        IEmployeeMod AccountNumber(string accountNumber);
        IEmployeeMod Notes(string notes);
        IEmployeeMod IncludeRetElement(params string[] retElements);
        IEmployeeMod FromDomainObject(Employee employee);
        IEmployeeMod FromDomainObject(Employee employee, bool neglectReferences);
        Employee Modify();
    }
}
