using ContactsApp;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace Contacts
{
    public partial class Form1 : Form
    {
        List<Contact> contacts = new List<Contact>();
        ContactsFileStorage fileStorage = new ContactsFileStorage("kontakty.txt");
        SortType selectedSortType = SortType.Name;
        string helpFilename = "manual_pl.txt";
        Contact selectedContact;

        /// <summary>
        /// Displays contact data in the UI labels and status line. Hides the contact data panel if the index is out of range.
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
        /// Loads data from the contacts list into the ListBox lbContacts. Updates the status line with the number of contacts.
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

        /// <summary>
        /// Sorts the contacts list by name.
        /// </summary>
        private void SortByName()
        {
            contacts.Sort(delegate (Contact c1, Contact c2)
            {
                return string.Compare(c1.name, c2.name, new CultureInfo("pl-PL"), CompareOptions.IgnoreCase);
            });
        }

        /// <summary>
        /// Sorts the contacts list by surname.
        /// </summary>
        private void SortBySurname()
        {
            contacts.Sort(delegate (Contact c1, Contact c2)
            {
                return string.Compare(c1.surname, c2.surname, new CultureInfo("pl-PL"), CompareOptions.IgnoreCase);
                //return string.Compare(c1.surname, c2.surname, CultureInfo.CurrentCulture, CompareOptions.None);
            });
        }

        /// <summary>
        /// Sorts the contacts list by date.
        /// </summary>
        private void SortByDate()
        {
            contacts.Sort(delegate (Contact c1, Contact c2)
            {
                if (c1.date.Month > c2.date.Month)
                    return 1;
                else if (c1.date.Month < c2.date.Month) 
                    return -1;
                else
                {
                    if (c1.date.Day > c2.date.Day)
                        return 1;
                    else if (c1.date.Day < c2.date.Day)
                        return -1;
                    else
                    {
                        if (c1.date.Year > c2.date.Year)
                            return 1;
                        else if (c1.date.Year < c2.date.Year)
                            return -1;
                        else
                            return 0;
                    }
                }
            });
        }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads contacts from file, sorts them by name, and refreshes the contact list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Prepares the form for adding a new contact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContact(object sender, EventArgs e)
        {
            selectedContact = null;
            lbContacts.ClearSelected();

            pContactData.Visible = false;
            pEditContact.Visible = true;
            pSearch.Visible = false;

            tbName.Text = null;
            tbSurname.Text = null;
            dtpDate.Text = null;
            tbPhone.Text = null;

            lTitle.Text = "Dodaj kontakt";
            bSubmit.Text = "Dodaj";
        }

        /// <summary>
        /// Handles input for the phone number field, ensuring only digits and control characters are allowed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Validates and adds a new contact to the list. Updates the UI and persists the contact list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactSubmit(object sender, EventArgs e)
        {
            bool err = false;
            gbName.ForeColor = Color.Black;
            gbSurname.ForeColor = Color.Black;
            gbPhone.ForeColor = Color.Black;

            if (tbName.Text == "")
            {
                gbName.ForeColor = Color.Red;
                err = true;
            }
            if (tbSurname.Text == "")
            {
                gbSurname.ForeColor = Color.Red;
                err = true;
            }
            if (tbPhone.Text == "" || tbPhone.Text.Length != 9)
            {
                gbPhone.ForeColor = Color.Red;
                err = true;
            }

            if (err)
                return;


            // getting the values out of the fields
            Contact contact = new Contact(
                tbName.Text,
                tbSurname.Text,
                tbPhone.Text,
                DateOnly.Parse(dtpDate.Text)
                );

            // clearing the form fields
            tbName.Text = null;
            tbSurname.Text = null;
            dtpDate.Text = null;
            tbPhone.Text = null;

            // filter out the duplicates
            if (contacts.Exists(c => c.Equals(contact)))
                return;

            // editing
            if (selectedContact != null)
                contacts.Remove(selectedContact);

            // saving new contact to in-app list
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
        }

        /// <summary>
        /// Handles the selection of a contact from the list and displays the contact's details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectContact(object sender, EventArgs e)
        {
            int index = lbContacts.SelectedIndex;

            pContactData.Visible = true;
            pEditContact.Visible = false;
            pSearch.Visible = false;

            tbName.Text = null;
            tbSurname.Text = null;
            dtpDate.Text = null;
            tbPhone.Text = null;

            ViewContact(index);
        }

        /// <summary>
        /// Saves the contact list to the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToFile(object sender, EventArgs e)
        {
            fileStorage.SaveToFile(contacts);
        }

        /// <summary>
        /// Sets the sorting type to Name and sorts the contact list accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Sets the sorting type to Surname and sorts the contact list accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Sets the sorting type to Date and sorts the contact list accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Clears the file storage and the contact list. Updates the UI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearFileStorage(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz usunąć wszystkie kontakty?", "Czyszczenie bazy kontaktów", MessageBoxButtons.OKCancel);

            if (result == DialogResult.No) return;

            fileStorage.ClearFileStorage();
            contacts.Clear();
            pContactData.Visible = false;
            pEditContact.Visible = false;
            pSearch.Visible = false;

            tbName.Text = null;
            tbSurname.Text = null;
            dtpDate.Text = null;
            tbPhone.Text = null;

            RefreshContactsList();
        }

        /// <summary>
        /// Deletes the selected contact and updates the UI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteContact(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Czy na pewno chcesz usunąć kontakt:\n{selectedContact.ToString()}?", "Usuwanie kontaktu", MessageBoxButtons.OKCancel);

            if (result == DialogResult.No) return;

            contacts.Remove(selectedContact);

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

            // updating ui
            RefreshContactsList();
            if (contacts.Count == 0)
            {
                lbContacts.ClearSelected();
                pContactData.Visible = false;
                pEditContact.Visible = false;
                pSearch.Visible = false;
            }
            else
            {
                selectedContact = contacts.First();
                lbContacts.SelectedIndex = 0;
                ViewContact(0);
            }
        }

        /// <summary>
        /// Prepares the form for editing the selected contact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContact(object sender, EventArgs e)
        {
            if (selectedContact == null) return;

            lTitle.Text = "Edytuj kontakt";
            bSubmit.Text = "Zatwierdź zmiany";

            pContactData.Visible = false;
            pEditContact.Visible = true;
            pSearch.Visible = false;

            tbName.Text = selectedContact.name;
            tbSurname.Text = selectedContact.surname;
            tbPhone.Text = selectedContact.phone;
            dtpDate.Text = selectedContact.date.ToShortDateString();
        }

        /// <summary>
        /// Displays the search panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search(object sender, EventArgs e)
        {
            pContactData.Visible = false;
            pEditContact.Visible = false;
            pSearch.Visible = true;

            tbName.Text = null;
            tbSurname.Text = null;
            dtpDate.Text = null;
            tbPhone.Text = null;
        }

        /// <summary>
        /// Searches for a contact by name and surname. Updates the UI with the search result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchSubmit(object sender, EventArgs e)
        {
            string searchPhrase = tbSearch.Text;

            var result = contacts
                .Where(c => $"{c.name} {c.surname}".Contains(searchPhrase, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();

            if (result != null)
            {
                int index = contacts.IndexOf(result);
                lbContacts.SelectedIndex = index;
                ViewContact(index);
            } 
            else if (selectedContact == null)
            {
                lbContacts.SelectedIndex = 0;
                ViewContact(0);
            }
            pContactData.Visible = true;
            pEditContact.Visible = false;
            pSearch.Visible = false;
            tbSearch.Text = null;
        }

        /// <summary>
        /// Start the process to open the help file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenHelpFile(object sender, EventArgs e)
        {
            if (File.Exists(helpFilename))
            {
                Process process = new Process();
                process.StartInfo.FileName = helpFilename;
                process.StartInfo.UseShellExecute = true;
                process.Start();
            }
        }

        /// <summary>
        /// Shows the author info in a MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowAuthorInfo(object sender, EventArgs e)
        {
            MessageBox.Show("Autorem aplikacji jest Jakub Irla");
        }
    }
}
