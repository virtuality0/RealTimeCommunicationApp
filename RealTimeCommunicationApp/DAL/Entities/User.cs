using System.ComponentModel.DataAnnotations;

namespace RealTimeCommunicationApp.DAL.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Role { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }
        public string? Country { get; set; }
        public string? Gender { get; set; }
        public DateTime DOB { get; set; }
        public string? Status { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
