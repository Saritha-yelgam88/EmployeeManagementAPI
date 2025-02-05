namespace EmployeeManagementAPI.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string Address1 { get; set; } = "";
        public string WorkerType { get; set; } = "Employee"; // Can be "Employee", "Supervisor", "Manager"
    }
}
