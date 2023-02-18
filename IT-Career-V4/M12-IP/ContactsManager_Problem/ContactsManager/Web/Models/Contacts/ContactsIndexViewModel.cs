using System.Collections;
using System.Collections.Generic;
using Web.Models.Shared;

namespace Web.Models.Contacts
{
    public class ContactsIndexViewModel
    {
        public PagerViewModel Pager { get; set; }

        public ICollection<ContactsViewModel> Items { get; set; }
    }
}
