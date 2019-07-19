using QuickBooks.Net.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace QuickBooks.Net.Modify
{
    public class EntityModBase<IReturnMod, TReturn> :
        ModifyBase<IReturnMod, TReturn>
    {

        public EntityModBase(IQBSessionInternal session, string requestName, string responseName, string addElementName)
            : base(session, requestName, responseName, addElementName)
        { }

        public virtual IReturnMod ListID(string listId)
        {
            AddUpdateMessage("ListID", listId);
            return _returnMod;
        }

        public virtual IReturnMod EditSequence(string editSequence)
        {
            AddUpdateMessage("EditSequence", editSequence);
            return _returnMod;
        }

        public virtual IReturnMod Name(string name)
        {
            AddUpdateMessage("Name", name);
            return _returnMod;
        }

        public virtual IReturnMod IsActive(bool isActive)
        {
            AddUpdateMessage("IsActive", isActive);
            return _returnMod;
        }

        public virtual IReturnMod Salutation(string salutation)
        {
            AddUpdateMessage("Salutation", salutation);
            return _returnMod;
        }

        public virtual IReturnMod CompanyName(string companyName)
        {
            AddUpdateMessage("CompanyName", companyName);
            return _returnMod;
        }

        public virtual IReturnMod FirstName(string firstName)
        {
            AddUpdateMessage("FirstName", firstName);
            return _returnMod;
        }

        public virtual IReturnMod MiddleName(string middleName)
        {
            if (middleName.Length > 1) middleName = middleName.Substring(0, 1);
            AddUpdateMessage("MiddleName", middleName);
            return _returnMod;
        }

        public virtual IReturnMod LastName(string lastName)
        {
            AddUpdateMessage("LastName", lastName);
            return _returnMod;
        }

        public virtual IReturnMod JobTitle(string JobTitle)
        {
            AddUpdateMessage("JobTitle", JobTitle);
            return _returnMod;
        }

        public virtual IReturnMod Phone(string phone)
        {
            AddUpdateMessage("Phone", phone);
            return _returnMod;
        }

        public virtual IReturnMod AltPhone(string altPhone)
        {
            AddUpdateMessage("AltPhone", altPhone);
            return _returnMod;
        }

        public virtual IReturnMod Fax(string fax)
        {
            AddUpdateMessage("Fax", fax);
            return _returnMod;
        }

        public virtual IReturnMod Email(string email)
        {
            AddUpdateMessage("Email", email);
            return _returnMod;
        }

        public virtual IReturnMod Contact(string contact)
        {
            AddUpdateMessage("Contact", contact);
            return _returnMod;
        }

        public virtual IReturnMod AltContact(string altContact)
        {
            AddUpdateMessage("AltContact", altContact);
            return _returnMod;
        }

        public virtual IReturnMod AccountNumber(string accountNumber)
        {
            AddUpdateMessage("AccountNumber", accountNumber);
            return _returnMod;
        }

        public virtual IReturnMod Notes(string notes)
        {
            AddUpdateMessage("Notes", notes);
            return _returnMod;
        }

        public virtual IReturnMod Terms(Reference terms)
        {
            AddReference("TermsRef", terms);
            return _returnMod;
        }

        public virtual IReturnMod CreditLimit(decimal creditLimit)
        {
            AddUpdateMessage("CreditLimit", creditLimit);
            return _returnMod;
        }

        public virtual IReturnMod IncludeRetElement(params string[] retElements)
        {
            foreach (var elementName in retElements)
                AddMessageAllowDuplicates("IncludeRetElement", elementName);
            return _returnMod;
        }

        protected virtual void AddReference(string elementName, Reference reference)
        {
            if (!String.IsNullOrEmpty(reference.ListID))
                AddUpdateMessage(elementName, "ListID", reference.ListID);
            if (!String.IsNullOrEmpty(reference.FullName))
                AddUpdateMessage(elementName, "FullName", reference.FullName);
        }

        protected virtual void AddAdditionalContactRef(string element, AdditionalContactRef additionalContactRef)
        {
            var contactRefElementName = "AdditionalContactRef";
            var lineXML = new XElement(contactRefElementName);
            var order = _xmlBase.ElementOrder.ChildrenOrder[0].ChildrenOrder
                .Where(x => x.Name == contactRefElementName)
                .Single();

            AddUpdateMessage(lineXML, order, "ContactName", additionalContactRef.ContactName);
            AddUpdateMessage(lineXML, order, "ContactValue", additionalContactRef.ContactValue);

            _xmlBase.InsertXElement(_xmlBase.Xml.Element(element), lineXML, _xmlBase.ElementOrder.ChildrenOrder[0]);
        }

        protected void AddAddress(string elementName, Address address)
        {
            if (!String.IsNullOrEmpty(address.Addr1))
                AddUpdateMessage(elementName, "Addr1", address.Addr1);
            if (!String.IsNullOrEmpty(address.Addr2))
                AddUpdateMessage(elementName, "Addr2", address.Addr2);
            if (!String.IsNullOrEmpty(address.Addr3))
                AddUpdateMessage(elementName, "Addr3", address.Addr3);
            if (!String.IsNullOrEmpty(address.Addr4))
                AddUpdateMessage(elementName, "Addr4", address.Addr4);
            if (!String.IsNullOrEmpty(address.Addr5))
                AddUpdateMessage(elementName, "Addr5", address.Addr5);
            if (!String.IsNullOrEmpty(address.City))
                AddUpdateMessage(elementName, "City", address.City);
            if (!String.IsNullOrEmpty(address.State))
                AddUpdateMessage(elementName, "State", address.State);
            if (!String.IsNullOrEmpty(address.PostalCode))
                AddUpdateMessage(elementName, "PostalCode", address.PostalCode);
            if (!String.IsNullOrEmpty(address.Country))
                AddUpdateMessage(elementName, "Country", address.Country);
            if (!String.IsNullOrEmpty(address.Note))
                AddUpdateMessage(elementName, "Note", address.Note);
        }

        protected virtual void AddCCInfo(string elementName, CCInfo creditCard)
        {
            if (!String.IsNullOrEmpty(creditCard.CreditCardNumber))
                AddUpdateMessage(elementName, "CreditCardNumber", creditCard.CreditCardNumber);
            if (creditCard.ExpirationMonth != 0)
                AddUpdateMessage(elementName, "ExpirationMonth", creditCard.ExpirationMonth);
            if (creditCard.ExpirationYear != 0)
                AddUpdateMessage(elementName, "ExpirationYear", creditCard.ExpirationYear);
            if (!String.IsNullOrEmpty(creditCard.NameOnCard))
                AddUpdateMessage(elementName, "NameOnCard", creditCard.NameOnCard);
            if (!String.IsNullOrEmpty(creditCard.CreditCardAddress))
                AddUpdateMessage(elementName, "CreditCardAddress", creditCard.CreditCardAddress);
            if (!String.IsNullOrEmpty(creditCard.CreditCardPostalCode))
                AddUpdateMessage(elementName, "CreditCardPostalCode", creditCard.CreditCardPostalCode);
        }
    }
}
