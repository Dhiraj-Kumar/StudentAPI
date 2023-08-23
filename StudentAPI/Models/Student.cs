namespace StudentAPI.Models
{
    public class Student
    {
        // add following properties to this class 
        // Id, FirstName, LastName, Email, Phone, Address
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        // add other properties here
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;   
        public string Address { get; set; } = string.Empty;
    }
}
