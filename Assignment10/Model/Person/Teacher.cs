namespace PerrinOwensA10.Model.Person
{
    public class Teacher : Person
    {
        private const string Unknown = "Unknown";
        private string department;

        public string Department
        {
            get => department;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value), "Department cannot be null");
                department = string.IsNullOrWhiteSpace(value) ? Unknown : value;
            }
        }

        /*public string Department { get; set; }*/

        private Teacher()
        {

        }

        public Teacher(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        public Teacher(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress, string department) : base(firstName, lastName, id, homeAddress)
        {
            Department = department ?? throw new ArgumentNullException(nameof(department));
        }

        public override string ToString() => $"{FirstName} {LastName} : ID – {Id}; Department – {Department}";

        public override string Details => $"{FirstName} {LastName} (ID: {Id})\n{HomeAddress}\nDepartment: {Department}";
    }
}
