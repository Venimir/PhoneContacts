using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhoneContacts
{
    public partial class App : Application
    {
        public static IList<Contact> Contacts { get; private set; }
        public App()
        {
            InitializeComponent();
            fillContatcsList();

            var nav = new NavigationPage(new PhoneContactsPage());
            nav.BarBackgroundColor = Color.Black;
            nav.BarTextColor = Color.ForestGreen;

            MainPage = nav;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected void fillContatcsList()
        {
            Contacts = new List<Contact>();

            Contacts.Add(new Contact { Name = "Ivan Kratunkov", PhoneNumber = "08999999999" });
            Contacts.Add(new Contact { Name = "Ivan Kratunkov", PhoneNumber = "08999999998" });
            Contacts.Add(new Contact { Name = "Ivan Kratunkov", PhoneNumber = "08999999997" });
            Contacts.Add(new Contact { Name = "Ivan Kratunkov", PhoneNumber = "08999999996" });
            Contacts.Add(new Contact { Name = "Ivan Kratunkov", PhoneNumber = "08999999995" });
            Contacts.Add(new Contact { Name = "Ivan Kratunkov", PhoneNumber = "08999999994" });
            Contacts.Add(new Contact { Name = "Ivan Kratunkov", PhoneNumber = "08999999993" });
            Contacts.Add(new Contact { Name = "Ivan Kratunkov", PhoneNumber = "08999999992" });
            Contacts.Add(new Contact { Name = "Ivan Kratunkov", PhoneNumber = "08999999991" });
            Contacts.Add(new Contact { Name = "Ivan Kratunkov", PhoneNumber = "08999999990" });
            Contacts.Add(new Contact { Name = "Ivan Kratunkov", PhoneNumber = "08999999900" });
            Contacts.Add(new Contact { Name = "Ivan Kratunkov", PhoneNumber = "08999999911" });
            Contacts.Add(new Contact { Name = "Ivan Kratunkov", PhoneNumber = "08999999912" });
        }
    }
}
