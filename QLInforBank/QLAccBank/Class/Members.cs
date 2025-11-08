namespace QLAccBank.Class
{
    public class Members
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public DateTime JoinDate { get; set; }
        public string AvatarPath { get; set; }

        public Members(string fullName, string email, string phone, string position, DateTime joinDate, string avatarPath = "")
        {
            FullName = fullName;
            Email = email;
            Phone = phone;
            Position = position;
            JoinDate = joinDate;
            AvatarPath = avatarPath;
        }

    }
}
