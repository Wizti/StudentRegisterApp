namespace StudentRegisterApplication.Model
{
    internal class Address
    {
        public int Id { get; set; }
        public string Street { get; set; } = "";
        public string City { get; set; } = "";
        public int PostalCode { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public Address(string street, string city, int postalCode)
        {
            Street = street;
            City = city;
            PostalCode = postalCode;
        }

        public override string ToString()
        {
            return $"{Street}, {PostalCode}, {City}";
        }
    }
}
