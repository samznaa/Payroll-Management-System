using System;
using System.ComponentModel.DataAnnotations;

namespace TeacherProject.Models
{
	public class Calender
	{
        [Key]
		public int Id { get; set; }
		public string NepaliCalenderName { get; set; }
		public string EnglishCslenderName { get; set; }
		 
	}
}
