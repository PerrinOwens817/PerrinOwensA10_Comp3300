namespace PerrinOwensA10.Model.Address
{
    /// <summary>
    /// Represents an address with street, city, state, and zip code.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the street address.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the city of the address.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state of the address.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the zip code of the address.
        /// </summary>
        public int Zip { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with default values.
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with specified values.
        /// </summary>
        /// <param name="street">The street address.</param>
        /// <param name="city">The city of the address.</param>
        /// <param name="state">The state of the address.</param>
        /// <param name="zip">The zip code of the address.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="street"/>  <paramref name="city"/>, or <paramref name="state"/> is null.</exception>
        public Address(string street, string city, string state, int zip)
        {
            Street = street ?? throw new ArgumentNullException(nameof(street));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            Zip = zip;
        }

        /// <summary>
        /// Returns a strinf that represents the current address.
        /// </summary>
        /// <returns>A string that represents the current address.</returns>
        public override string ToString()
        {
            return State + Environment.NewLine + City + ", " + State + Environment.NewLine + Zip + Environment.NewLine;
        }
    }
}
