namespace PerrinOwensA10.Model.Person
{
    /// <summary>
    /// Represents a staff member with specific title.
    /// </summary>
    public class Staff : Person
    {
        /// <summary>
        /// Gets or sets the title of the staff member.
        /// </summary>
        private string title;

        /// <summary>
        /// Gets or sets the title of the staff member.
        /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff"/> class.
        /// </summary>
        private Staff()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff"/> class with specified first and last names.
        /// </summary>
        /// <param name="firstName">The first name of the staff member.</param>
        /// <param name="lastName">The last name of the staff member.</param>
        public Staff(string firstName, string lastName) : this(firstName, lastName, 0, null, "Unknown")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff"/> class with specified first name, last name, and ID.
        /// </summary>
        /// <param name="firstName">The first name of the staff member.</param>
        /// <param name="lastName">The last name of the staff member.</param>
        /// <param name="id">The ID of the staff member.</param>
        public Staff(string firstName, string lastName, int id) : this(firstName, lastName, id, null, "Unknown")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff"/> class with specified first name, last name, ID, and home address.
        /// </summary>
        /// <param name="firstName">The first name of the staff member.</param>
        /// <param name="lastName">The last name of the staff member.</param>
        /// <param name="id">The ID of the staff member.</param>
        /// <param name="homeAddress">The home address of the staff member.</param>
        public Staff(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, "Unknown")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff"/> class with specified first name, last name, ID, home address, and title.
        /// </summary>
        /// <param name="firstName">The first name of the staff member.</param>
        /// <param name="lastName">The last name of the staff member.</param>
        /// <param name="id">The ID of the staff member.</param>
        /// <param name="homeAddress">The home address of the staff member.</param>
        /// <param name="title">The title of the staff member.</param>
        public Staff(string firstName, string lastName, int id, Address.Address homeAddress, string title) : base(firstName, lastName, id, homeAddress)
        {
            Title = title;
        }

        /// <summary>
        /// Returns a string that represents the current staff member.
        /// </summary>
        /// <returns>A string that represents the current staff member.</returns>
        public override string ToString() => $"{FirstName} {LastName} : ID – {Id}; Title – {Title}";

        /// <summary>
        /// Gets the details of the staff member.
        /// </summary>
        public override string Details => $"{FirstName} {LastName} (ID: {Id}/Title: {Title})\n{HomeAddress}";
    }
}