using System.Collections.ObjectModel;
using seibereaContactsPage.Models;
using System.Linq;

namespace seibereaContactsPage.ViewModels
{
    public class ContactsViewModel
    {
        public ObservableCollection<Grouping<string, seibereaContactsPage.Models.Contact>> GroupedContacts { get; set; }

        public ContactsViewModel()
        {
            var contacts = new List<seibereaContactsPage.Models.Contact>
            {
                new seibereaContactsPage.Models.Contact { Name = "Alice", Photo = "pic1.png", Email = "alice@example.com", PhoneNumber = "123-456-7890", Description = "Friend from school" },
                new seibereaContactsPage.Models.Contact { Name = "Bob", Photo = "pic2.png", Email = "bob@example.com", PhoneNumber = "234-567-8901", Description = "Work colleague" },
                new seibereaContactsPage.Models.Contact { Name = "Charlie", Photo = "pic3.png", Email = "charlie@example.com", PhoneNumber = "345-678-9012", Description = "Neighbor" },
                new seibereaContactsPage.Models.Contact { Name = "David", Photo = "pic4.png", Email = "david@example.com", PhoneNumber = "456-789-0123", Description = "Gym buddy" },
                new seibereaContactsPage.Models.Contact { Name = "Eve", Photo = "pic1.png", Email = "eve@example.com", PhoneNumber = "567-890-1234", Description = "Cousin" },
                new seibereaContactsPage.Models.Contact { Name = "Fabian", Photo = "pic2.png", Email = "fabian@example.com", PhoneNumber = "567-890-1234", Description = "Friend" },
                new seibereaContactsPage.Models.Contact { Name = "Gabe", Photo = "pic4.png", Email = "gabe@example.com", PhoneNumber = "567-890-1234", Description = "Friend" },
                new seibereaContactsPage.Models.Contact { Name = "Hazel", Photo = "pic3.png", Email = "hazel@example.com", PhoneNumber = "567-890-1234", Description = "Friend" },
                new seibereaContactsPage.Models.Contact { Name = "Izzy", Photo = "pic1.png", Email = "izzy@example.com", PhoneNumber = "567-890-1234", Description = "Friend" },
                new seibereaContactsPage.Models.Contact { Name = "Jacob", Photo = "pic4.png", Email = "jacob@example.com", PhoneNumber = "567-890-1234", Description = "Friend" },
                new seibereaContactsPage.Models.Contact { Name = "Karol", Photo = "pic3.png", Email = "karol@example.com", PhoneNumber = "567-890-1234", Description = "Friend" },
                new seibereaContactsPage.Models.Contact { Name = "Lauren", Photo = "pic2.png", Email = "Lauren@example.com", PhoneNumber = "567-890-1234", Description = "Friend" },
                new seibereaContactsPage.Models.Contact { Name = "Moe", Photo = "pic1.png", Email = "moe@example.com", PhoneNumber = "567-890-1234", Description = "Friend" },
                new seibereaContactsPage.Models.Contact { Name = "Nate", Photo = "pic4.png", Email = "izzy@example.com", PhoneNumber = "567-890-1234", Description = "Friend" },
                new seibereaContactsPage.Models.Contact { Name = "Otto", Photo = "pic2.png", Email = "otto@example.com", PhoneNumber = "567-890-1234", Description = "Friend" }

            };

            var groupedContacts = from contact in contacts
                                  group contact by contact.Name[0].ToString()
                                  into contactGroup
                                  select new Grouping<string, seibereaContactsPage.Models.Contact>(contactGroup.Key, contactGroup);

            GroupedContacts = new ObservableCollection<Grouping<string, seibereaContactsPage.Models.Contact>>(groupedContacts);
        }
    }

    public class Grouping<K, T> : ObservableCollection<T>
    {
        public K Key { get; private set; }

        public Grouping(K key, IEnumerable<T> items)
        {
            Key = key;
            foreach (var item in items)
                this.Items.Add(item);
        }
    }
}
