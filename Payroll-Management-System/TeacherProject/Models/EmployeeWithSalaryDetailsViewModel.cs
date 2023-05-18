using System;
using System.ComponentModel.DataAnnotations;

namespace TeacherProject.Models
{
	public class EmployeeWithSalaryDetailsViewModel
	{
        public string EmployeeName { get; set; }
        public string MonthName { get; set; }
        public decimal TotalSalary { get; set; }
        public int EmployeeId { get; set; }
        public int CalenderId { get; set; }
      

	}
}
