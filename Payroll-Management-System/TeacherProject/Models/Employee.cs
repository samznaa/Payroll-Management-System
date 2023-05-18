using System;
using System.ComponentModel.DataAnnotations;

namespace TeacherProject.Models
{
	public class Employee
	{
        [Key]
		public int Id { get; set; }
		public string FullName { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime DOB { get; set; }
		public string PermanentAddress { get; set; }
		public string TemporaryAddress { get; set; }
		public string ProfilePhoto { get; set; }
		public string CitizenShipFrontImage { get; set; }
		public string CitizenShipBackImage { get; set; }
		public bool IsActive { get; set; }
		public DateTime AddedOn { get; set; }
		public string AddedBy { get; set; }
		public bool DeletedBy { get; set; }
		public DateTime DeletedOn { get; set; }
		public bool IsDeleted { get; set; }
	}
}
