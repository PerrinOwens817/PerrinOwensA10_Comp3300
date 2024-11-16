namespace PerrinOwensA10.Model.Person
{
    public class Student : Person
    {
        private const string Undeclared = "Undeclared";
        private string major;
        private string minor;

        /*public string Major { get; set; }

        public string Minor { get; set; }*/

        public string Major
        {
            get => major;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value), "Major cannot be null");
                major = string.IsNullOrWhiteSpace(value) ? Undeclared : value;
            }
        }

        public string Minor
        {
            get => minor;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value), "Minor cannot be null");
                minor = string.IsNullOrWhiteSpace(value) ? Undeclared : value;
            }
        }

        private Student()
        {

        }

        public Student(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        public Student(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        public Student(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        public Student(string firstName, string lastName, int id, Address.Address homeAddress, string major) : base(firstName, lastName, id, homeAddress)
        {
            Major = major ?? throw new ArgumentNullException(nameof(major));
            Minor = Undeclared;
        }

        public override string Details
        {
            get
            {
                string details = $"{FirstName} {LastName} (ID: {Id})\n{HomeAddress}\nMajor: {Major}";
                if (Minor != Undeclared)
                {
                    details += $", Minor: {Minor}";
                }
                return details;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"; Major - {Major}";
        }
    }
}
