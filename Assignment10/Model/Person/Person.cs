namespace PerrinOwensA10.Model.Person
{
    /// <summary>
    /// Represents a person with first name, last name, ID, and home address.
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Gets or sets the first name of the person.
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Gets or sets the last name of the person.
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Gets or sets the ID of the person.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Gets or sets the home address of the person.
        /// </summary>
        public Address.Address HomeAddress { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        protected Person()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class with specified first and last names.
        /// </summary>
        /// <param name="firstName">The first name of the person.</param>
        /// <param name="lastName">The Last name of the person.</param>
        public Person(string firstName, string lastName) : this(firstName, lastName, 0, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class with specified first name, last name, and ID.
        /// </summary>
        /// <param name="firstName">The first name of the person.</param>
        /// <param name="lastName">The last name of the person.</param>
        /// <param name="id">The ID of the person.</param>
        public Person(string firstName, string lastName, int id) : this(firstName, lastName, id, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class with specified first name, last name, ID, and home address.
        /// </summary>
        /// <param name="firstName">The first name of the person.</param>
        /// <param name="lastName">The last name of the person.</param>
        /// <param name="id">The ID of the person.</param>
        /// <param name="homeAddress">The home address of the person.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="firstName"/> or <paramref name="lastName"/> is null.</exception>
        public Person(string firstName, string lastName, int id, Address.Address homeAddress)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Id = id;
            HomeAddress = homeAddress;
        }

        /// <summary>
        /// Gets the details of the person.
        /// </summary>
        public abstract string Details { get; }

        /// <summary>
        /// Returns a string that represents the current person.
        /// </summary>
        /// <returns>A string that represents the current person.</returns>
        public override string ToString()
        {
            return $"{FirstName} {LastName} : ID - {Id}";
        }
    }
}
