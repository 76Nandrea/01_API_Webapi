namespace API_Gepiparri.DAL.Model
{
    public class UserVM
    {
        public int Id { get; set; }
        public string FName { get; set; } = string.Empty;
        public string LName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string FullName => $"{FName} {LName}";
    }
}
