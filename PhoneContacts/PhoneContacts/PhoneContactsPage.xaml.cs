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
    public partial class PhoneContactsPage : ContentPage
    {
        public IList<Contact> Contacts { get; private set; }
        public PhoneContactsPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = App.Contacts;
        }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(
                new ContactPage()
                {
                    BindingContext = new Contact()
                });
            
        }

        async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(
                    new ContactPage()
                    {
                        BindingContext = e.SelectedItem as Contact
                    });
            }

        }
    }
}