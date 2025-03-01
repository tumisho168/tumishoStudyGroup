using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tumishoStudyGroup.Models
{
    public class StudentModel
    {
        [Display(Name = "STUDENT NUMBER")]
        public string StudentNumber { get; set; }

        [Display(Name = "NAME")]
        public string StudentName { get; set; }

        [Display(Name = "SURNAME")]
        public string StudentSurname { get; set; }

        [Display(Name = "EMAIL ADDRESS")]
        public string StudentEmail { get; set; }
    }
}