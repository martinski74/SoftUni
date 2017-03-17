using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    class Startup
    {
        static void Main(string[] args)
        {
            var context = new SoftUniEntities();
            //17.Call Stored Procedure
            //CallStoredProcedure(context);

            //18.Employees Max Salaries
            MaxSalaries(context);

        }

        private static void MaxSalaries(SoftUniEntities context)
        {
            foreach (var dep in context.Departments)
            {
                decimal maxSalary = context.Employees.Where(e => e.Department.Name == dep.Name).ToList().Max(x => x.Salary);
                if (maxSalary < 30000 || maxSalary > 70000)
                {
                    Console.WriteLine($"{dep.Name} - {maxSalary:F2}");
                }
            }
        }

        private static void CallStoredProcedure(SoftUniEntities context)
        {
            string[] name = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            SqlParameter firstName = new SqlParameter("@firstName", name[0]);
            SqlParameter lastName = new SqlParameter("@lastName", name[1]);

            //Procedure body

            //CREATE PROCEDURE GetEmployeeProjects @firstName NVARCHAR(MAX), 
            //@lastName NVARCHAR(MAX)
            //AS
            //SELECT CONCAT(p.Name, ' - ', SUBSTRING(p.Description, 1, 30), '..., ', p.StartDate) FROM Employees AS e
            //LEFT JOIN EmployeesProjects AS ep
            //ON e.EmployeeID = ep.EmployeeID
            //LEFT JOIN Projects AS p
            //ON ep.ProjectID = p.ProjectID
            //WHERE e.FirstName = @firstName and e.LastName = @lastName
            var projects = context.Database.SqlQuery<string>($"execute GetEmployeeProjects @firstName,@lastName", firstName, lastName).ToList();

            foreach (var projcet in projects)
            {
                Console.WriteLine(projcet);
            }
        }
    }
}
