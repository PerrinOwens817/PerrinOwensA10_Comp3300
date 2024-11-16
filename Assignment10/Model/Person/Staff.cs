namespace PerrinOwensA10.Model.Person
{
    public class Staff : Person
    {
        private string title;

        public string Title
        {
            get => title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be null or an empty string", nameof(value));
                }
                title = value;
            }
        }

        private Staff()
        {
        }

        public Staff(string firstName, string lastName) : this(firstName, lastName, 0, null, "Unknown")
        {
        }

        public Staff(string firstName, string lastName, int id) : this(firstName, lastName, id, null, "Unknown")
        {
        }

        public Staff(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, "Unknown")
        {
        }

        public Staff(string firstName, string lastName, int id, Address.Address homeAddress, string title) : base(firstName, lastName, id, homeAddress)
        {
            Title = title;
        }

        public override string ToString() => $"{FirstName} {LastName} : ID – {Id}; Title – {Title}";

        public override string Details => $"{FirstName} {LastName} (ID: {Id}/Title: {Title})\n{HomeAddress}";
    }
}