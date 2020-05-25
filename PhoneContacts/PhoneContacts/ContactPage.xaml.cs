using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhoneContacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        
        public ContactPage()
        {
            InitializeComponent();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            var contact = (Contact) BindingContext;
            if (!App.Contacts.Contains(contact))
            {
                App.Contacts.Add(contact);
            }
            
            NavigationPage nav = new NavigationPage(new PhoneContactsPage() { Title = "My Contacts" });
            Application.Current.MainPage = nav;
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            var contact = (Contact)BindingContext;
            App.Contacts.Remove(contact);

            NavigationPage nav = new NavigationPage(new PhoneContactsPage() { Title = "My Contacts" });
            Application.Current.MainPage = nav;
        }

        private void CancelButton_Clicked(object sender, EventArgs e)
        {
           Navigation.PopAsync();
        }
    }
}