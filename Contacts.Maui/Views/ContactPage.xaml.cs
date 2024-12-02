using Contacts.Maui.Models;
using System.Collections.ObjectModel;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

public partial class ContactPage : ContentPage
{
	public ContactPage()
	{
		InitializeComponent();       
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var contacts = new ObservableCollection<Contact>(ContactRepository.GetAllContacts());

        listContacts.ItemsSource = contacts;
    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listContacts.SelectedItem = null;
    }

    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listContacts.SelectedItem != null)
        {
            // Todo: Logic 
            await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id ={((Contact)listContacts.SelectedItem).ContactId}");
        } 
    }
}