using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsChallenge
{
    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }
        public int GradeNum { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
