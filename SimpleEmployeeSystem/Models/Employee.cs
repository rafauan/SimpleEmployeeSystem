namespace SimpleEmployeeSystem.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? JobPosition { get; set; }
		public DateTime? HireDate { get; set; }
		public string? EmployeeStatus { get; set; }
		public ICollection<Job>? Jobs { get; set; }
	}
}
