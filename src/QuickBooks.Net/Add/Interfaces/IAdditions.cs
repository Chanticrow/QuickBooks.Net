using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBooks.Net.Add
{
    public interface IAdditions
    {
        ICustomerAdd Customer { get; }
        IEmployeeAdd Employee { get; }
        IVendorAdd Vendor { get; }
        IJournalEntryAdd JournalEntry { get; }
    }
}
