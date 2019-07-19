using QuickBooks.Net.Domain;
using System;
using System.Collections.Generic;

namespace QuickBooks.Net.Modify
{
    public interface ICustomerMod
    {
        ICustomerMod ListID(string listId);
        ICustomerMod EditSequence(string editSequence);
        ICustomerMod Name(string name);
        ICustomerMod IsActive(bool isActive);
        ICustomerMod Parent(Reference parentRef);
        ICustomerMod CompanyName(string companyName);
        ICustomerMod Salutation(string salutation);
        ICustomerMod FirstName(string firstName);
        ICustomerMod MiddleName(string middleName);
        ICustomerMod LastName(string lastName);
        ICustomerMod BillAddress(Address billAddress);
        ICustomerMod ShipAddress(Address shipAddress);
        ICustomerMod Phone(string phone);
        ICustomerMod AltPhone(string altPhone);
        ICustomerMod AdditionalContactRef(List<AdditionalContactRef> additionalContactRefs);
        ICustomerMod Fax(string fax);
        ICustomerMod Email(string email);
        ICustomerMod Contact(string contact);
        ICustomerMod AltContact(string altContact);
        ICustomerMod CustomerType(Reference typeRef);
        ICustomerMod Terms(Reference termsRef);
        ICustomerMod SalesRep(Reference salesRef);
        ICustomerMod SalesTaxCode(Reference salesTaxCode);
        ICustomerMod ItemSalesTax(Reference itemSalesTax);
        ICustomerMod ResaleNumber(string resaleNumber);
        ICustomerMod AccountNumber(string accountNumber);
        ICustomerMod CreditLimit(decimal creditLimit);
        ICustomerMod PreferredPaymentMethod(Reference prefPayMethod);
        ICustomerMod CreditCardInfo(CCInfo creditCard);
        ICustomerMod JobStatus(string jobStatus);
        ICustomerMod JobStartDate(DateTime startDate);
        ICustomerMod JobProjectedEndDate(DateTime projectedEndDate);
        ICustomerMod JobEndDate(DateTime endDate);
        ICustomerMod JobDesc(string description);
        ICustomerMod JobType(Reference jobType);
        ICustomerMod Notes(string notes);
        ICustomerMod PriceLevel(Reference priceLevel);
        ICustomerMod IncludeRetElement(params string[] retElements);
        ICustomerMod FromDomainObject(Customer customer);
        ICustomerMod FromDomainObject(Customer customer, bool neglectReferences);
        Customer Modify();
    }
}
