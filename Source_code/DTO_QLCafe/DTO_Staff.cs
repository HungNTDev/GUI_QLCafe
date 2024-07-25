namespace DTO_QLCafe
{
    public class DTO_Staff
    {
        public string idStaff { get; set; }
        public string fullName { get; set; }
        public string imageStaff { get; set; }
        public string email { get; set; }
        public string passwordStaff { get; set; }
        public string roleStaff { get; set; }
        public int statusStaff { get; set; }

        public string IdStaff
        {
            get { return idStaff; }
            set { idStaff = value; }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string ImageStaff
        {
            get { return imageStaff; }
            set { imageStaff = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string PasswordStaff
        {
            get { return passwordStaff; }
            set { passwordStaff = value; }
        }
        public string RoleStaff
        {
            get { return roleStaff; }
            set { roleStaff = value; }
        }
        public int StatusStaff
        {
            get { return statusStaff; }
            set { statusStaff = value; }
        }
        public DTO_Staff(string fullName, string imageStaff, string email, string roleStaff, int statusStaff)
        {
            this.fullName = fullName;
            this.imageStaff = imageStaff;
            this.email = email;
            this.roleStaff = roleStaff;
            this.statusStaff = statusStaff;
        }
        public DTO_Staff()
        {

        }
    }
}
