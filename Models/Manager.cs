namespace EmployeeManagementAPI.Models
{
    public class Manager : Worker
    {
        public decimal AnnualSalary { get; set; }
        public decimal MaxExpenseAmount { get; set; }
    }
}
