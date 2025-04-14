namespace MyPortfolio.Dal.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string MessageDetail { get; set; }
        public DateTime SendDate { get; set; }
        public bool isRead { get; set; }
    }
}
