////////////////////////////////////////////////////////////////////////////////
//DATE         DEVELOPER               DESCRIPTION
//2021-03-13   logan23b                class created
//tinfo200:[2021-03-11-logan23b-dykstra1] - added Student Class to Models
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //tinfo200:[2021-03-11-logan23b-dykstra1] - properties that make up a student
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        
        public ICollection<Enrollment> Enrollments { get; set; }


    }
}
