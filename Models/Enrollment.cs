////////////////////////////////////////////////////////////////////////////////
///DATE         DEVELOPER               DESCRIPTION
///2021-03-13   logan23b                class created 
///// added Enrollment Class to Models
//tinfo200:[2021-03-11-logan23b-dykstra1] - created Properties inside class Enrollment
//tinfo200:[2021-03-11-logan23b-dykstra1] - created enum Grade for Letter grades and nullable value for courses

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        //tinfo200:[2021-03-11-logan23b-dykstra1] - ID propety = primary key of database table
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public  Grade? Grade { get; set; }
        public Student Student { get; set; }


    }
}