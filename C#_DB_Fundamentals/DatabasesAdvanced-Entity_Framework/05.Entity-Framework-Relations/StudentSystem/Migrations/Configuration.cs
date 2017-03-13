namespace StudentSystem.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentSystem.StudentSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "StudentSystem.StudentSystemContext";
        }
        //02.Seed some data in the Database
        protected override void Seed(StudentSystemContext context)
        {
            Course course =
                            new Course()
                            {
                                Name = "C#",
                                Description = "some sharp",
                                StartDate = DateTime.Today,
                                EndDate = new DateTime(2017, 2, 3),
                                Price = 2,
                                Homeworks = new List<Homework>()
                                {
                                    new Homework()
                                    {
                                        Content = "C# homework",
                                        Type = ContentType.Application,
                                        SubmissionDate = DateTime.Today,
                                        Student = new Student()
                                        {
                                            Name = "Pesho",
                                            RegistrationDate = DateTime.Today,
                                            PhoneNumber = "08869899899"
                                        }
                                    },
                                    new Homework()
                                    {
                                        Content = "java homework",
                                        Type = ContentType.Pdf,
                                        SubmissionDate = DateTime.Today,
                                        Student = new Student()
                                        {
                                            Name = "Stancho",
                                            RegistrationDate = DateTime.Today,
                                            PhoneNumber = "08869899899"
                                        }
                                    }
                                 },

                                Students = new List<Student>()
                                 {
                                    new Student()
                                    {
                                        Name = "Ivo",
                                        RegistrationDate = DateTime.Today,
                                        PhoneNumber = "08869899899"
                                    } ,
                                     new Student()
                                    {
                                        Name = "Reni",
                                        RegistrationDate = DateTime.Today,
                                        PhoneNumber = "08869899899"
                                    }
                                  },
                                Resources = new List<Resource>()
                                  {
                                    new Resource()
                                    {
                                        Name = "rsrc",
                                        Type = ResourceType.Document,
                                        Url = "usadl"
                                    },
                                    new Resource()
                                    {
                                         Name = "redasdas",
                                         Type = ResourceType.Document,
                                         Url = "fsafasf"
                                    }
                                 }
                            };
            context.Courses.Add(course);
            context.SaveChanges();

        }
    }
}
