using QuickBooks.Net.Domain;
using QuickBooks.Net.Utilities;
using System;
using System.Collections.Generic;

namespace QuickBooks.Net.Modify
{
    public class EmployeeMod :
        EntityModBase<IEmployeeMod, Employee>,
        IEmployeeMod
    {
        public EmployeeMod(IQBSessionInternal session)
            : base(session, "EmployeeModRq", "EmployeeModRs", "EmployeeMod")
        {
            _returnMod = this;
        }

        public IEmployeeMod AdditionalContactRef(List<AdditionalContactRef> additionalContactRefs)
        {
            foreach (var addContact in additionalContactRefs)
            {
                AddAdditionalContactRef("EmployeeMod", addContact);
            }
            return this;
        }

        public IEmployeeMod AdjustedServiceDate(DateTime adjustedServiceDate)
        {
            AddUpdateMessage("AdjustedServiceDate", adjustedServiceDate);
            return this;
        }

        public IEmployeeMod BillingRateRef(Reference billingRateRef)
        {
            AddReference("BillingRateRef", billingRateRef);
            return this;
        }

        public IEmployeeMod BirthDate(DateTime birthDate)
        {
            AddUpdateMessage("BirthDate", birthDate);
            return this;
        }

        public IEmployeeMod Department(string department)
        {
            AddUpdateMessage("Department", department);
            return this;
        }

        public IEmployeeMod Description(string description)
        {
            AddUpdateMessage("Description", description);
            return this;
        }

        public IEmployeeMod DisabilityDesc(string disabilityDesc)
        {
            AddUpdateMessage("DisabilityDesc", disabilityDesc);
            return this;
        }

        public IEmployeeMod Disabled(string disabled)
        {
            AddUpdateMessage("Disabled", disabled);
            return this;
        }

        public IEmployeeMod EmployeeAddress(Address employeeAddress)
        {
            AddAddress("EmployeeAddress", employeeAddress);
            return this;
        }

        public IEmployeeMod EmployeeType(string employeeType)
        {
            AddUpdateMessage("EmployeeType", employeeType);
            return this;
        }

        public IEmployeeMod Ethnicity(string ethnicity)
        {
            AddUpdateMessage("Ethnicity", ethnicity);
            return this;
        }

        public IEmployeeMod Exempt(string exempt)
        {
            AddUpdateMessage("Exempt", exempt);
            return this;
        }

        public IEmployeeMod Gender(string gender)
        {
            AddUpdateMessage("Gender", gender);
            return this;
        }

        public IEmployeeMod HiredDate(DateTime hiredDate)
        {
            AddUpdateMessage("HiredDate", hiredDate);
            return this;
        }

        public IEmployeeMod KeyEmployee(string keyEmployee)
        {
            AddUpdateMessage("KeyEmployee", keyEmployee);
            return this;
        }

        public IEmployeeMod MilitaryStatus(string miltaryStatus)
        {
            AddUpdateMessage("MilitaryStatus", miltaryStatus);
            return this;
        }

        public IEmployeeMod Mobile(string mobile)
        {
            AddUpdateMessage("Mobile", mobile);
            return this;
        }

        public IEmployeeMod OnFile(string onFile)
        {
            AddUpdateMessage("OnFile", onFile);
            return this;
        }

        public IEmployeeMod OriginalHireDate(DateTime originalHireDate)
        {
            AddUpdateMessage("OriginalHireDate", originalHireDate);
            return this;
        }

        public IEmployeeMod Pager(string pager)
        {
            AddUpdateMessage("Pager", pager);
            return this;
        }

        public IEmployeeMod PagerPIN(string pagerPin)
        {
            AddUpdateMessage("PagerPIN", pagerPin);
            return this;
        }

        public IEmployeeMod PartOrFullTime(string partOrFullTime)
        {
            AddUpdateMessage("PartOrFullTime", partOrFullTime);
            return this;
        }

        public IEmployeeMod PrintAs(string printAs)
        {
            AddUpdateMessage("PrintAs", printAs);
            return this;
        }

        public IEmployeeMod ReleasedDate(DateTime releasedDate)
        {
            AddUpdateMessage("ReleasedDate", releasedDate);
            return this;
        }

        public IEmployeeMod SSN(string ssn)
        {
            AddUpdateMessage("SSN", ssn);
            return this;
        }

        public IEmployeeMod USCitizen(string usCitizen)
        {
            AddUpdateMessage("USCitizen", usCitizen);
            return this;
        }

        public IEmployeeMod USVeteran(string usVeteran)
        {
            AddUpdateMessage("USVeteran", usVeteran);
            return this;
        }

        public IEmployeeMod WorkAuthExpireDate(DateTime workAuthExpireDate)
        {
            AddUpdateMessage("WorkAuthExpireDate", workAuthExpireDate);
            return this;
        }

        public IEmployeeMod FromDomainObject(Employee employee)
        {
            return FromDomainObject(employee, false);
        }

        public IEmployeeMod FromDomainObject(Employee employee, bool neglectReferences)
        {
            ListID(employee.ListID);
            EditSequence(employee.EditSequence);
            IsActive(employee.IsActive);
            if (!String.IsNullOrEmpty(employee.Salutation))
                Salutation(employee.Salutation);
            if (!String.IsNullOrEmpty(employee.FirstName))
                FirstName(employee.FirstName);
            if (!String.IsNullOrEmpty(employee.MiddleName))
                MiddleName(employee.MiddleName);
            if (!String.IsNullOrEmpty(employee.LastName))
                LastName(employee.LastName);
            if (!String.IsNullOrEmpty(employee.JobTitle))
                JobTitle(employee.JobTitle);
            if (!String.IsNullOrEmpty(employee.Department))
                Department(employee.Department);
            if (!String.IsNullOrEmpty(employee.Description))
                Description(employee.Description);
            if (employee.EmployeeAddress != null)
                EmployeeAddress(employee.EmployeeAddress);
            if (!String.IsNullOrEmpty(employee.PrintAs))
                PrintAs(employee.PrintAs);
            if (!String.IsNullOrEmpty(employee.Phone))
                Phone(employee.Phone);
            if (!String.IsNullOrEmpty(employee.Mobile))
                Mobile(employee.Mobile);
            if (!String.IsNullOrEmpty(employee.Pager))
                Pager(employee.Pager);
            if (!String.IsNullOrEmpty(employee.PagerPIN))
                Description(employee.PagerPIN);
            if (!String.IsNullOrEmpty(employee.AltPhone))
                AltPhone(employee.AltPhone);
            if (!String.IsNullOrEmpty(employee.Fax))
                Fax(employee.Fax);
            if (!String.IsNullOrEmpty(employee.Email))
                Email(employee.Email);
            if (employee.AdditionalContactRef?.Count > 0)
                AdditionalContactRef(employee.AdditionalContactRef);
            if (!String.IsNullOrEmpty(employee.EmployeeType))
                EmployeeType(employee.EmployeeType);
            if (!String.IsNullOrEmpty(employee.PartOrFullTime))
                PartOrFullTime(employee.PartOrFullTime);
            if (!String.IsNullOrEmpty(employee.Exempt))
                Exempt(employee.Exempt);
            if (!String.IsNullOrEmpty(employee.KeyEmployee))
                KeyEmployee(employee.KeyEmployee);
            if (!String.IsNullOrEmpty(employee.Gender))
                Gender(employee.Gender);
            if (employee.HiredDate != DateTime.MinValue)
                HiredDate(employee.HiredDate);
            if (employee.OriginalHireDate != DateTime.MinValue)
                OriginalHireDate(employee.OriginalHireDate);
            if (employee.AdjustedServiceDate != DateTime.MinValue)
                AdjustedServiceDate(employee.AdjustedServiceDate);
            if (employee.ReleasedDate != DateTime.MinValue)
                ReleasedDate(employee.ReleasedDate);
            if (employee.BirthDate != DateTime.MinValue)
                BirthDate(employee.BirthDate);
            if (!String.IsNullOrEmpty(employee.USCitizen))
                USCitizen(employee.USCitizen);
            if (!String.IsNullOrEmpty(employee.Ethnicity))
                Ethnicity(employee.Ethnicity);
            if (!String.IsNullOrEmpty(employee.Disabled))
                Disabled(employee.Disabled);
            if (!String.IsNullOrEmpty(employee.DisabilityDesc))
                DisabilityDesc(employee.DisabilityDesc);
            if (!String.IsNullOrEmpty(employee.OnFile))
                OnFile(employee.OnFile);
            if (employee.WorkAuthExpireDate != DateTime.MinValue)
                WorkAuthExpireDate(employee.WorkAuthExpireDate);
            if (!String.IsNullOrEmpty(employee.USVeteran))
                USVeteran(employee.USVeteran);
            if (!String.IsNullOrEmpty(employee.MilitaryStatus))
                MilitaryStatus(employee.MilitaryStatus);
            if (!String.IsNullOrEmpty(employee.AccountNumber))
                AccountNumber(employee.AccountNumber);
            if (!String.IsNullOrEmpty(employee.Notes))
                Notes(employee.Notes);
            if (employee.BillingRateRef != null && !neglectReferences)
                BillingRateRef(employee.BillingRateRef);
            return this;
        }

        protected override void SetElementOrder()
        {
            AddElementOrder(
                new ElementPosition("EmployeeMod",
                    "ListID",
                    "EditSequence",
                    "IsActive",
                    "Salutation",
                    "FirstName",
                    "MiddleName",
                    "LastName",
                    "JobTitle",
                    "Department",
                    "Description",
                    new ElementPosition("EmployeeAddress",
                        "Addr1",
                        "Addr2",
                        "City",
                        "State",
                        "PostalCode",
                        "Country"),
                    "PrintAs",
                    "Phone",
                    "Mobile",
                    "Pager",
                    "PagerPIN",
                    "AltPhone",
                    "Fax",
                    "SSN",
                    "Email",
                    ElementPosition.Ref("AdditionalContactRef"),
                    "EmployeeType",
                    "PartOrFullTime",
                    "Exempt",
                    "KeyEmployee",
                    "Gender",
                    "HiredDate",
                    "OriginalHireDate",
                    "AdjustedServiceDate",
                    "ReleasedDate",
                    "BirthDate",
                    "USCitizen",
                    "Ethnicity",
                    "Disabled",
                    "DisabilityDesc",
                    "OnFile",
                    "WorkAuthExpireDate",
                    "USVeteran",
                    "MilitaryStatus",
                    "AccountNumber",
                    "Notes",
                    "IncludeRetElement"));
        }
    }
}
