using System;
using System.ComponentModel.DataAnnotations;

namespace TeacherProject.Models
{
	public class EmployeeTotalSalary
	{
        [Key]
		public int Id { get; set; }
		public string FullName { get; set; }
		public int EmployeeId { get; set; }
		public int AddedCalender { get; set; }
		public DateTime AddedOn { get; set; }
		public string AddedBy { get; set; }
	}

}

