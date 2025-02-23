using seibereaContactsPage.Models;

namespace seibereaContactsPage.Views
{
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
        }

        private async void OnContactSelected(object sender, SelectionChangedEventArgs e)
        {
            var selectedContact = e.CurrentSelection.FirstOrDefault() as seibereaContactsPage.Models.Contact;
            if (selectedContact != null)
            {
                var detailsPage = new ContactDetailsPage();
                detailsPage.BindingContext = selectedContact;
                await Navigation.PushAsync(detailsPage);
            }
        }
    }
}
