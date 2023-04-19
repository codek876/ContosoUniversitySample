using ContosoUniversitySample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using static ContosoUniversitySample.Models.Enrollment;

namespace ContosoUniversitySample.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SchoolContext(
            serviceProvider.GetRequiredService<DbContextOptions<SchoolContext>>()))
        {
            if (context.Students.Any())
            {
                return;
            }

            context.Students.AddRange(
                new Student
                {
                    FirstMidName = "Carson",
                    LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2005-09-01")
                },
                new Student
                {
                    FirstMidName = "Meredith",
                    LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2002-09-01")
                },
                new Student { FirstMidName = "Arturo", LastName = "Anand", EnrollmentDate = DateTime.Parse("2003-09-01") },
                new Student { FirstMidName = "Gytis", LastName = "Barzdukas", EnrollmentDate = DateTime.Parse("2002-09-01") },
                new Student { FirstMidName = "Yan", LastName = "Li", EnrollmentDate = DateTime.Parse("2002-09-01") },
                new Student { FirstMidName = "Peggy", LastName = "Justice", EnrollmentDate = DateTime.Parse("2001-09-01") },
                new Student { FirstMidName = "Laura", LastName = "Norman", EnrollmentDate = DateTime.Parse("2003-09-01") },
                new Student
                {
                    FirstMidName = "Nino",
                    LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01")
                }
            );

            if (context.Courses.Any())
            {
                return;
            }

            context.Courses.AddRange(
                new Course { CourseId = 1050, Title = "Chemistry", Credits = 3 },
            new Course { CourseId = 4022, Title = "Microeconomics", Credits = 3 },
            new Course { CourseId = 4041, Title = "Macroeconomics", Credits = 3 },
            new Course { CourseId = 1045, Title = "Calculus", Credits = 4 },
            new Course { CourseId = 3141, Title = "Trigonometry", Credits = 4 },
            new Course { CourseId = 2021, Title = "Composition", Credits = 3 },
            new Course { CourseId = 2042, Title = "Literature", Credits = 4 }
                );

            if (context.Enrollments.Any())
            {
                return;
            }

            context.Enrollments.AddRange(
                new Enrollment { StudentId = 1, CourseId = 1050, Grades = Grade.A },
            new Enrollment { StudentId = 1, CourseId = 4022, Grades = Grade.C },
            new Enrollment { StudentId = 1, CourseId = 4041, Grades = Grade.B },
            new Enrollment { StudentId = 2, CourseId = 1045, Grades = Grade.B },
            new Enrollment { StudentId = 2, CourseId = 3141, Grades = Grade.F },
            new Enrollment { StudentId = 2, CourseId = 2021, Grades = Grade.F },
            new Enrollment { StudentId = 3, CourseId = 1050 },
            new Enrollment { StudentId = 4, CourseId = 1050 },
            new Enrollment { StudentId = 4, CourseId = 4022, Grades = Grade.F },
            new Enrollment { StudentId = 5, CourseId = 4041, Grades = Grade.C },
            new Enrollment { StudentId = 6, CourseId = 1045 },
            new Enrollment { StudentId = 7, CourseId = 3141, Grades = Grade.A }
                );

            context.SaveChanges();
        }
    }
}
