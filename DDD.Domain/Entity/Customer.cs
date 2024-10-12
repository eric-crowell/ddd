namespace DDD.Domain.Customer {
  public class Customer {
    public Guid CustomerId { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }

    /**
     * Constructor ensures that the customer is created with all the required fields...
     * That is... the first name, last name, and email address.
    */
    public Customer(
      string firstName,
      string lastName,
      string email
    ) {
      if (string.IsNullOrWhiteSpace(firstName)) {
        throw new ArgumentException("First name cannot be empty", nameof(firstName));
      }
      if (string.IsNullOrWhiteSpace(lastName)) {
        throw new ArgumentException("Last name cannot be empty", nameof(lastName));
      }
      if (string.IsNullOrWhiteSpace(email)) {
        throw new ArgumentException("Email cannot be empty", nameof(email));
      }

      CustomerId = Guid.NewGuid();
      FirstName = firstName;
      LastName = lastName;
      Email = email;
    }
  }
}
