namespace PerrinOwensA10.Model.Person
{
    /// <summary>
    /// Represents a teacher with a specific department.
    /// </summary>
    public class Teacher : Person
    {
        private const string Unknown = "Unknown";
        private string department;

        /// <summary>
        /// Gets or sets the department of the teacher.
        /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class.
        /// </summary>
        private Teacher()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class with specified first and last names.
        /// </summary>
        /// <param name="firstName">The first name of the teacher.</param>
        /// <param name="lastName">The last name of the teacher.</param>
        public Teacher(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class with specified first name, last name, and ID.
        /// </summary>
        /// <param name="firstName">The first name of the teacher.</param>
        /// <param name="lastName">The last name of the teacher.</param>
        /// <param name="id">The ID of the teacher.</param>
        public Teacher(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class with specified first name, last name, ID, and home address.
        /// </summary>
        /// <param name="firstName">The first name of the teacher.</param>
        /// <param name="lastName">The last name of the teacher.</param>
        /// <param name="id">The ID of the teacher.</param>
        /// <param name="homeAddress">The home address of the teacher.</param>
        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class with specified first name, last name, ID, home address, and department.
        /// </summary>
        /// <param name="firstName">The first name of the teacher.</param>
        /// <param name="lastName">The last name of the teacher.</param>
        /// <param name="id">The ID of the teacher.</param>
        /// <param name="homeAddress">The home address of the teacher.</param>
        /// <param name="department">The department of the teacher.</param>
        /// <exception cref="ArgumentNullException">Thrown when the department is null.</exception>
        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress, string department) : base(firstName, lastName, id, homeAddress)
        {
            Department = department ?? throw new ArgumentNullException(nameof(department));
        }

        /// <summary>
        /// Returns a string that represents the current teacher.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{FirstName} {LastName} : ID – {Id}; Department – {Department}";

        /// <summary>
        /// Gets the details of the teacher.
        /// </summary>
        public override string Details => $"{FirstName} {LastName} (ID: {Id})\n{HomeAddress}\nDepartment: {Department}";
    }
}
