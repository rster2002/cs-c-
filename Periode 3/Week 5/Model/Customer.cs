namespace Model {
    public class Customer {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }

        public override string ToString() {
            return $"{FullName} ({EmailAddress})";
        }
    }
}
