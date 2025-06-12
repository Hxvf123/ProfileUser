namespace ProfileUser.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public int BloodTypeId { get; set; }
    }
}
