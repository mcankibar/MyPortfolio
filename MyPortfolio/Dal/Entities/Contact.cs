namespace MyPortfolio.Dal.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string AlternativePhoneNumber { get; set; }
        public string Email { get; set; }
        public string AlternativeEmail { get; set; }
        public string Address { get; set; }
    }
}
