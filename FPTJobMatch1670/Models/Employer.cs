namespace FPTJobMatch1670.Models
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Company { get; set; }
        public ICollection<Job> Job { get; set; }
        public ICollection<Application> Application { get; set; }
    }
}
