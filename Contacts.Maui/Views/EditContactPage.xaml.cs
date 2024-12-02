using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

[QueryProperty(nameof(ContactId), "Id")]
public partial class EditContactPage : ContentPage
{
    private Contact? contact;

    public EditContactPage()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
    
    public string ContactId
    {
        set
        {
            contact = ContactRepository.GetContactById(int.Parse(value));
            if (contact != null)
            {
                entryName.Text = contact.Name;
                entryAddress.Text = contact.Address;
                entryCity.Text = contact.City;
                entryState.Text = contact.State;
                entryZip.Text = contact.ZipCode;
                entryCountry.Text = contact.Country;
                entryPhone.Text = contact.Phone;
                entryEmail.Text = contact.Email;
            }
        }
    }

    private void btnUpdate_Clicked(object sender, EventArgs e)
    {
        contact.Name= entryName.Text ;
        contact.Address= entryAddress.Text ;
        contact.City= entryCity.Text ;
        contact.State= entryState.Text ;
        contact.ZipCode= entryZip.Text ;
        contact.Country = entryCountry.Text ;
        contact.Phone = entryPhone.Text ;
        contact.Email = entryEmail.Text ;

        ContactRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync("..");
    }
}