using System;

namespace Contacts
{
    internal class ContactsFileStorage
    {
        string filename;

        public ContactsFileStorage(string filename)
        {
            this.filename = filename;
        }

        public List<Contact> LoadFromFile()
        {
            if (!File.Exists(filename))
            {
                File.Create(filename);

                return new List<Contact>();
            }

            List<Contact> contacts = new List<Contact>();

            foreach (string line in File.ReadAllLines(filename))
            {
                string[] contactData = line.Split(" ");
                DateOnly do_result;
                int i_result;
                if (contactData.Length != 4 || !DateOnly.TryParse(contactData[3], out do_result) || !int.TryParse(contactData[2], out i_result) || contactData[2].Length != 9)
                    continue;
                Contact contact = new Contact(
                    contactData[0], 
                    contactData[1], 
                    contactData[2], 
                    DateOnly.Parse(contactData[3])
                    );
                contacts.Add(contact);
            }

            return contacts;
        }

        public void SaveToFile(List<Contact> contacts)
        {
            if (File.Exists(filename))
                File.Delete(filename);

            foreach (Contact contact in contacts)
            {
                File.AppendAllText(filename, contact.ToString() + "\n");
            }
        }

        public void ClearFileStorage()
        {
            File.Delete(filename);
        }
    }
}
