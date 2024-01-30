using System.ComponentModel.DataAnnotations;

namespace SimpleEmployeeSystem.Models
{
	public class Job
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? JobStatus { get; set; }
		public int EmployeeId { get; set; }
		public Employee? Employee { get; set; }
	}
}
