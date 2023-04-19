using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversitySample.Models;

public class Enrollment
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public int EnrollmentId { get; set; }
    public int CourseId { get; set; }
    public int StudentId { get; set; }
    public Grade? Grades { get; set; }
    public Course Course { get; set; }
    public Student Student { get; set; }
}
