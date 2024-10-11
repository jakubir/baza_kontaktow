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
        Contact selectedContact = null;

        private void viewContact(int index)
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

        // load data from contacts list to listBox lbContacts
        private void refreshContactsList()
        {
            lbContacts.Items.Clear();
            contacts.ForEach(contact =>
            {
                lbContacts.Items.Add(contact.ToSortTypeString(selectedSortType));
            });
            slNumberOfPeople.Text = contacts.Count.ToString();
        }

        private void sortByName()
        {
            contacts.Sort(delegate (Contact c1, Contact c2)
            {
                return c1.name.CompareTo(c2.name);
            });
        }

        private void sortBySurname()
        {
            contacts.Sort(delegate (Contact c1, Contact c2)
            {
                return c1.surname.CompareTo(c2.surname);
            });
        }

        private void sortByDate()
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

            sortByName();

            if (contacts.Count > 0)
            {
                refreshContactsList();
                pContactData.Visible = true;
                viewContact(0);
                lbContacts.SelectedIndex = 0;
            }
        }

        private void AddContact(object sender, EventArgs e)
        {
            pEditContact.Visible = true;
        }

        private void dateInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && (tbDate.Text.Length == 2 || tbDate.Text.Length == 5))
            {
                tbDate.Text += "/";
                tbDate.SelectionStart = tbDate.Text.Length;
                tbDate.ScrollToCaret();
            }
        }

        private void phoneInput(object sender, KeyPressEventArgs e)
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

        private void editSubmit(object sender, EventArgs e)
        {
            Contact contact = new Contact(
                tbName.Text,
                tbSurname.Text,
                tbPhone.Text,
                DateOnly.Parse(dtpDate.Text)
                );
            contacts.Add(contact);
            refreshContactsList();
            pEditContact.Visible = false;
        }

        private void contactSelected(object sender, EventArgs e)
        {
            int index = lbContacts.SelectedIndex;

            viewContact(index);
        }

        private void saveToFile(object sender, EventArgs e)
        {
            fileStorage.SaveToFile(contacts);
        }

        private void byNameClick(object sender, EventArgs e)
        {
            if (selectedSortType == SortType.Name) return;

            selectedSortType = SortType.Name;

            miSortByName.Checked = true;
            miSortBySurname.Checked = false;
            miSortByDate.Checked = false;

            sortByName();
            refreshContactsList();
            slActive.Text = selectedContact.ToSortTypeString(selectedSortType);
        }

        private void bySurnameClick(object sender, EventArgs e)
        {
            if (selectedSortType == SortType.Surname) return;

            selectedSortType = SortType.Surname;

            miSortByName.Checked = false;
            miSortBySurname.Checked = true;
            miSortByDate.Checked = false;

            sortBySurname();
            refreshContactsList();
            slActive.Text = selectedContact.ToSortTypeString(selectedSortType);
        }

        private void byDateClick(object sender, EventArgs e)
        {
            if (selectedSortType == SortType.Date) return;

            selectedSortType = SortType.Date;

            miSortByName.Checked = false;
            miSortBySurname.Checked = false;
            miSortByDate.Checked = true;

            sortByDate();
            refreshContactsList();
            slActive.Text = selectedContact.ToSortTypeString(selectedSortType);
        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
