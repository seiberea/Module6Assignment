namespace seibereaContactsPage.Views
{
    public partial class ContactDetailsPage : ContentPage
    {
        public ContactDetailsPage()
        {
            InitializeComponent();
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
