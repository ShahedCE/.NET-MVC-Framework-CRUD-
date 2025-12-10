using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Basic_Project_MVC_Framework_.Models
{
	public class StudentViewModel
	{
		[Required]
		public string Name {  get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public int DepartmentId {  get; set; }	
	}
}