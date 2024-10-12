using ContactsApp;
using System;
using System.Diagnostics;

namespace Contacts
{
    public partial class Form1 : Form
    {
        List<Contact> contacts = new List<Contact>();
        ContactsFileStorage fileStorage = new ContactsFileStorage("kontakty.txt");
        SortType selectedSortType = SortType.Name;
        Contact selectedContact;

        /// <summary>
        /// Displaying contact data in labels and slActive
        /// </summary>
        /// <param name="index">Index in contacts list of contact to display</param>
        private void ViewContact(int index)
        {
            if (index < 0 || index >= contacts.Count)
            {
                pContactData.Visible = false;
                return;
            }

            selectedContact = contacts[index];

            lName.Text = selectedContact.name;
            lSurname.Text = selectedContact.surname;
            lPhone.Text = selectedContact.phone;
            lDate.Text = selectedContact.date.ToShortDateString();

            slActive.Text = selectedContact.ToSortTypeString(selectedSortType);
        }

        /// <summary>
        /// Load data from contacts list to listBox lbContacts
        /// </summary>
        private void RefreshContactsList()
        {
            lbContacts.Items.Clear();
            contacts.ForEach(contact =>
            {
                lbContacts.Items.Add(contact.ToSortTypeString(selectedSortType));
            });
            slNumberOfPeople.Text = contacts.Count.ToString();
        }

        private void SortByName()
        {
            contacts.Sort(delegate (Contact c1, Contact c2)
            {
                return c1.name.CompareTo(c2.name);
            });
        }

        private void SortBySurname()
        {
            contacts.Sort(delegate (Contact c1, Contact c2)
            {
                return c1.surname.CompareTo(c2.surname);
            });
        }

        private void SortByDate()
        {
            contacts.Sort(delegate (Contact c1, Contact c2)
            {
                return c1.date.CompareTo(c2.date);
            });
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contacts = fileStorage.LoadFromFile();

            SortByName();

            if (contacts.Count > 0)
            {
                RefreshContactsList();
                pContactData.Visible = true;
                ViewContact(0);
                lbContacts.SelectedIndex = 0;
            }
        }

        private void AddContact(object sender, EventArgs e)
        {
            pEditContact.Visible = true;
        }

        private void PhoneInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && (tbPhone.Text.Length == 3 || tbPhone.Text.Length == 7))
            {
                tbPhone.Text += "-";
                tbPhone.SelectionStart = tbPhone.Text.Length;
                tbPhone.ScrollToCaret();
            }
        }

        private void AddContactSubmit(object sender, EventArgs e)
        {
            // saving new contact to in-app list
            Contact contact = new Contact(
                tbName.Text,
                tbSurname.Text,
                tbPhone.Text,
                DateOnly.Parse(dtpDate.Text)
                );
            contacts.Add(contact);
            selectedContact = contact;
            
            // sorting the list
            switch (selectedSortType)
            {
                case SortType.Name:
                    SortByName();
                    break;
                case SortType.Surname:
                    SortBySurname();
                    break;
                case SortType.Date:
                    SortByDate();
                    break;
            }

            // finding the index of new item
            int index = contacts.FindIndex(c => c.Equals(contact));

            // updating ui
            RefreshContactsList();
            lbContacts.SelectedIndex = index;
            ViewContact(index);
            pEditContact.Visible = false;
            pContactData.Visible = true;

            // clearing the form fields
            tbName.Text = null;
            tbSurname.Text = null;
            dtpDate.Text = null;
            tbPhone.Text = null;
        }

        private void ContactSelected(object sender, EventArgs e)
        {
            int index = lbContacts.SelectedIndex;

            ViewContact(index);
        }

        private void SaveToFile(object sender, EventArgs e)
        {
            fileStorage.SaveToFile(contacts);
        }

        private void ByNameClick(object sender, EventArgs e)
        {
            if (selectedSortType == SortType.Name) return;

            selectedSortType = SortType.Name;

            miSortByName.Checked = true;
            miSortBySurname.Checked = false;
            miSortByDate.Checked = false;

            SortByName();
            RefreshContactsList();
            slActive.Text = selectedContact.ToSortTypeString(selectedSortType);
        }

        private void BySurnameClick(object sender, EventArgs e)
        {
            if (selectedSortType == SortType.Surname) return;

            selectedSortType = SortType.Surname;

            miSortByName.Checked = false;
            miSortBySurname.Checked = true;
            miSortByDate.Checked = false;

            SortBySurname();
            RefreshContactsList();
            slActive.Text = selectedContact.ToSortTypeString(selectedSortType);
        }

        private void ByDateClick(object sender, EventArgs e)
        {
            if (selectedSortType == SortType.Date) return;

            selectedSortType = SortType.Date;

            miSortByName.Checked = false;
            miSortBySurname.Checked = false;
            miSortByDate.Checked = true;

            SortByDate();
            RefreshContactsList();
            slActive.Text = selectedContact.ToSortTypeString(selectedSortType);
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearFileStorage(object sender, EventArgs e)
        {
            fileStorage.ClearFileStorage();
            contacts.Clear();
            pContactData.Visible = false;
            RefreshContactsList();
        }
    }
}
