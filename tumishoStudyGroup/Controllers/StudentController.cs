using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tumishoStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Students()
        {
            List<Models.StudentModel> students = new List<Models.StudentModel>();
            students.Add(new Models.StudentModel { StudentNumber = "u24885062", StudentName = "Tumisho", StudentSurname = "Matlala", StudentEmail = "tumisho.matlala@tuks.co.za" });
            students.Add(new Models.StudentModel { StudentNumber = "u22746995", StudentName = "Kgalalelo", StudentSurname = "Lethoko", StudentEmail = "kgalalelo.lethoko@tuks.co.za" });
            students.Add(new Models.StudentModel { StudentNumber = "u20731028", StudentName = "Nomvuyo", StudentSurname = "Mthimkhulu", StudentEmail = "nomvuyo.mthimkhulu@tuks.co.za" });
            students.Add(new Models.StudentModel { StudentNumber = "u24753328", StudentName = "Bulelo", StudentSurname = "Sibisi", StudentEmail = "bulelo.sibisi@tuks.co.za" });
            students.Add(new Models.StudentModel { StudentNumber = "u24986242", StudentName = "Palesa", StudentSurname = "Mphephu", StudentEmail = "palesa.mphephu@tuks.co.za" });


            return View(students);
        }
    }
}