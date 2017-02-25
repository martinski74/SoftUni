namespace SoftUni
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    public class StartUp
    {

        public static void Main(string[] args)
        {
            var grContext = new GringottsContext();
            var context = new SoftUniEntities();

            //FullInformation(context);
            //SalaryOver(context);
            //EmployeesFromSeattle(context);
            //AddAddress(context);
            //EmployeesInPeriod(context);
            //AddressByTown(context);
            //EmployeeWithId(context);
            //DepartmentsWithMoreEmployees(context);
            //FindLatestProjects(context);
            //IncreaseSalary(context);
            //FindEmployeeByFirstName(context);
            //FirstLetter(grContext);
            //DeletProject(context);
        }

        //03.Employees Full Information
        private static void FullInformation(SoftUniEntities context)
        {

            var employes = context.Employees
                .Select(c => new
                {
                    c.EmployeeID,
                    c.FirstName,
                    c.LastName,
                    c.MiddleName,
                    c.JobTitle,
                    c.Salary
                })
                .OrderBy(e => e.EmployeeID)
                .ToList();
            foreach (var emp in employes)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.MiddleName} {emp.JobTitle} {emp.Salary}");

            }

        }

        //04.Employees with salary over 50 000
        private static void SalaryOver(SoftUniEntities context)
        {
            var employees = context.Employees
                .Where(e => e.Salary > 50000)
                .Select(c => c.FirstName);
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }

        }

        //05.Employees from Seattle
        private static void EmployeesFromSeattle(SoftUniEntities context)
        {
            var employees = context.Employees
                .Where(e => e.Department.Name == "Research and Development")
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName);
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} from {emp.Department.Name} - ${emp.Salary:F2}");
            }

        }

        //06.Adding a new address and updating Employee
        private static void AddAddress(SoftUniEntities context)
        {
            //var address = new Address()
            //{
            //    AddressText = "Vitoshka 15",
            //    TownID = 4
            //};
            //context.Addresses.Add(address);
            //context.SaveChanges();

            //Employee emp = context.Employees.FirstOrDefault(e => e.LastName == "Nakov");
            //emp.Address = address;
            //context.SaveChanges();


            var address = new Address()
            {
                AddressText = "Vitoshka 15",
                TownID = 4
            };
            Employee emp = context.Employees.FirstOrDefault(e => e.LastName == "Nakov");
            emp.Address = address;
            context.SaveChanges();

            var addresses = context.Employees.OrderByDescending(e => e.AddressID).Take(10).ToList();

            foreach (var e in addresses)
            {
                Console.WriteLine(e.Address.AddressText);
            }
        }

        //07.Find Employees in period
        private static void EmployeesInPeriod(SoftUniEntities context)
        {
            var employyes = context.Employees
                .Where(e => e.Projects.Count(p => p.StartDate.Year >= 2001 && p.StartDate.Year <= 2003) > 0)
                .Take(30);
            foreach (var e in employyes)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} {e.Employee1.FirstName}");
                foreach (var p in e.Projects)
                {
                    Console.WriteLine($"--{p.Name} {p.StartDate} {p.EndDate}");
                }
            }

        }

        //08.Address bt Town Name
        private static void AddressByTown(SoftUniEntities context)
        {
            var addresses = context.Addresses
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(t => t.Town.Name)
                .Take(10)
                .ToList();

            foreach (var a in addresses)
            {
                Console.WriteLine($"{a.AddressText}, {a.Town.Name} - {a.Employees.Count} employees");
            }
        }

        //09.Employee with id 147
        private static void EmployeeWithId(SoftUniEntities context)
        {
            var e = context.Employees.Find(147);

            Console.WriteLine($"{e.FirstName} {e.LastName} {e.JobTitle}");

            foreach (var p in e.Projects.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{p.Name}");
            }

        }

        //10.Departments with more than 5 employees
        private static void DepartmentsWithMoreEmployees(SoftUniEntities context)
        {
            var department = context.Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(c => c.Employees.Count).ToList();


            foreach (var d in department)
            {
                Console.WriteLine($"{d.Name} {d.Employee.FirstName}");
                foreach (var em in d.Employees)
                {
                    Console.WriteLine($"{em.FirstName} {em.LastName} {em.JobTitle}");
                }
            }
        }

        //11.Find latest 10 projects
        private static void FindLatestProjects(SoftUniEntities context)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            var projects = context.Projects
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .OrderBy(p => p.Name);

            foreach (var p in projects)
            {
                Console.WriteLine($"{p.Name} {p.Description} {p.StartDate:M/d/yyyy h:mm:ss tt} {p.EndDate:M/d/yyyy h:mm:ss tt}");

            }

        }

        //12.Increase Salary
        private static void IncreaseSalary(SoftUniEntities context)
        {
            IEnumerable<Employee> employees = context.Employees
                 .Where(
                 e => e.Department.Name == "Engineering" ||
                     e.Department.Name == "Tool Design" ||
                     e.Department.Name == "Marketing" ||
                     e.Department.Name == "Information Services");

            foreach (Employee e in employees)
            {
                e.Salary += e.Salary * 0.12M;

                Console.WriteLine($"{e.FirstName} {e.LastName} (${e.Salary})");
            }

            context.SaveChanges();
        }


        //13.Find Employee by First name starting with 'SA'
        private static void FindEmployeeByFirstName(SoftUniEntities context)
        {
            var employees = context.Employees.Where(e => e.FirstName.ToLower().StartsWith("sa"));

            foreach (var e in employees)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:F4})");
            }

        }

        //14.First letter 
        private static void FirstLetter(GringottsContext grContext)
        {
            var letters = grContext.WizzardDeposits
                .Where(d => d.DepositGroup == "Troll Chest")
                .Select(w => w.FirstName)
                .ToList().Select(fn => fn[0])
                .Distinct()
                .OrderBy(c => c);
            foreach (var l in letters)
            {
                Console.WriteLine(l);
            }

        }

        //15.Delete project by ID
        private static void DeletProject(SoftUniEntities context)
        {
            var projects = context.Projects.Find(2);

            foreach (var emp in projects.Employees)
            {
                emp.Projects.Remove(projects);
            }
            context.Projects.Remove(projects);
            context.SaveChanges();

            var result = context.Projects.Take(10);
            foreach (var pr in result)
            {
                Console.WriteLine(pr.Name);
            }
        }
    }
}



