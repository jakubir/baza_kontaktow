namespace Contacts
{
    internal class Contact
    {
        public string name;
        public string surname;
        public string phone;
        public DateOnly date;

        public Contact(string name, string surname, string phone, DateOnly date)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.date = date;
        }

        private string ToNSString()
        {
            return $"{name} {surname}";
        }

        private string ToSNString()
        {
            return $"{surname} {name}";
        }

        private string ToDNSString()
        {
            return $"{date}: {name} {surname}";
        }

        public string ToSortTypeString(SortType selectedSortType)
        {
            string strContact = "";

            switch (selectedSortType)
            {
                case SortType.Name:
                    strContact = this.ToNSString();
                    break;
                case SortType.Surname:
                    strContact = this.ToSNString();
                    break;
                case SortType.Date:
                    strContact = this.ToDNSString();
                    break;
            }

            return strContact;
        }

        public override string ToString()
        {
            return $"{name} {surname} {phone} {date.ToShortDateString()}";
        }
    }
}
