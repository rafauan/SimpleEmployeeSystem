using Microsoft.EntityFrameworkCore;
using SimpleEmployeeSystem.Models;

namespace SimpleEmployeeSystem.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Job> Jobs { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Job>()
				.HasOne(j => j.Employee)
				.WithMany(e => e.Jobs)
				.HasForeignKey(j => j.EmployeeId);

			modelBuilder.Entity<Employee>().HasData(
				new Employee { Id = 1, Name = "Kacper Nowak", JobPosition = "Tester", HireDate = DateTime.Now, EmployeeStatus = "Hired" },
				new Employee { Id = 2, Name = "Jan Kowalski", JobPosition = "Developer", HireDate = DateTime.Now, EmployeeStatus = "Contract" },
				new Employee { Id = 3, Name = "Anna Wesołowska", JobPosition = "Tester", HireDate = DateTime.Now, EmployeeStatus = "PartTime" }
			);

			modelBuilder.Entity<Job>().HasData(
				new Job { Id = 1, Name = "Projekt A", Description = "Praca nad projektem A", JobStatus = "New", EmployeeId = 1 },
				new Job { Id = 2, Name = "Projekt B", Description = "Praca nad projektem B", JobStatus = "In Progress", EmployeeId = 2 },
				new Job { Id = 3, Name = "Projekt C", Description = "Praca nad projektem C", JobStatus = "Done", EmployeeId = 3 }
			);
		}
	}
}
