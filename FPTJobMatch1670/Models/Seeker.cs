namespace FPTJobMatch1670.Models
{
    public class Seeker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Resume { get; set; }
        public ICollection<Application> Application { get; set; }
    }
}
