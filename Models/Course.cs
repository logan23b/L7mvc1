////////////////////////////////////////////////////////////////////////////////
///DATE         DEVELOPER               DESCRIPTION
///2021-03-13   logan23b                class created
//tinfo200:[2021-03-11-logan23b-dykstra1] - added course class to models 
//tinfo200:[2021-03-11-logan23b-dykstra1] - created properties 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Course
    {
        //tinfo200:[2021-03-11-logan23b-dykstra1] - properties that makes up a course
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //tinfo200:[2021-03-11-logan23b-dykstra1] - dont generate primary key
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
