using Antlr.Runtime.Misc;
using Basic_Project_MVC_Framework_.DTOs;
using Basic_Project_MVC_Framework_.EF;
using Basic_Project_MVC_Framework_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Basic_Project_MVC_Framework_.Controllers
{
	public class StudentController : Controller
	{
		Entities db = new Entities();


		public static Student Convert(StudentDTO s)
		{
		

			return new Student()
			{
				Name = s.Name,
				Password = s.Password,
				Email = s.Email,
				DepartmentId= s.DepartmentId.Value
			};
		}

		public static StudentDTO Convert(Student s)
		{
			return new StudentDTO()
			{
				Name = s.Name,
				Email = s.Email,
				Password = s.Password,
				DepartmentId = s.DepartmentId
			};
		}

		public List<StudentDTO> Convert(List<Student> list)
		{
			var data= new List<StudentDTO>();	

			foreach(var item in list)
			{
				data.Add(Convert(item));
			}

			return data;
		}


		[HttpGet]
		public ActionResult StudentRegistration()
		{

			return View(new StudentViewModel());
		}

		[HttpPost]
		public ActionResult StudentRegistration(StudentDTO st)
		{
			
			if (ModelState.IsValid) {

				var student = Convert(st);  // Converting from StudentDTO to Student 
				db.Students.Add(student);
				db.SaveChanges();
				TempData["Msg"] = "Student " + st.Name + " Created";
				return RedirectToAction("StudentList");
		}
			return View(st);

		}

		public ActionResult StudentList() {
			var model= TempData["Student"] as StudentViewModel;

			return View(model);
			}
	}
}