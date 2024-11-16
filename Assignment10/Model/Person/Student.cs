namespace PerrinOwensA10.Model.Person
{
    /// <summary>
    /// Represents a student with a major and minor.
    /// </summary>
    public class Student : Person
    {
        private const string Undeclared = "Undeclared";
        private string major;
        private string minor;

        /// <summary>
        /// Gets or sets the major of the student.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the minor of the student.
        /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        private Student()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class with specified first and last names.
        /// </summary>
        /// <param name="firstName">The first name of the student.</param>
        /// <param name="lastName">The last name of the student.</param>
        public Student(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class with specified first name, last name, and ID.
        /// </summary>
        /// <param name="firstName">The first name of the student.</param>
        /// <param name="lastName">The last name of the student.</param>
        /// <param name="id">The ID of the student.</param>
        public Student(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class with specified first name, last name, ID, and home address.
        /// </summary>
        /// <param name="firstName">The first name of the student.</param>
        /// <param name="lastName">The last name of the student.</param>
        /// <param name="id">The ID of the student.</param>
        /// <param name="homeAddress">The home address of the student.</param>
        public Student(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class with specified first name, last name, ID, home address, and major.
        /// </summary>
        /// <param name="firstName">The first name of the student.</param>
        /// <param name="lastName">The last name of the student.</param>
        /// <param name="id">The ID of the student.</param>
        /// <param name="homeAddress">The home address of the student.</param>
        /// <param name="major">The major of the student</param>
        /// <exception cref="ArgumentNullException">Thrown when the major is null.</exception>
        public Student(string firstName, string lastName, int id, Address.Address homeAddress, string major) : base(firstName, lastName, id, homeAddress)
        {
            Major = major ?? throw new ArgumentNullException(nameof(major));
            Minor = Undeclared;
        }

        /// <summary>
        /// Gets the details of the student.
        /// </summary>
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

        /// <summary>
        /// Returns a string that represents the current student.
        /// </summary>
        /// <returns>A string that represents the current student.</returns>
        public override string ToString()
        {
            return base.ToString() + $"; Major - {Major}";
        }
    }
}
