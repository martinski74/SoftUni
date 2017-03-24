using AutoMapper;
using AutoMapper.QueryableExtensions;
using EmployeeApp.Data;
using EmployeeApp.Models;
using EmployeeApp.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Client
{
    class Startup
    {
        static void Main(string[] args)
        {
            //01.Simple Mapping
            ConfigureAutomapping();

            //Employee emp = new Employee()
            //{
            //    FirstName = "Pesho",
            //    LastName = "Petrov",
            //    Salary = 100m,
            //    Birthday = DateTime.Now,
            //    Address = "Tintiava 15"
            //};
            //EmployeeDTO dto = Mapper.Map<EmployeeDTO>(emp);
            //Console.WriteLine($"{dto.FirstName} - {dto.LastName} - {dto.Salary}");

            //Uncomment for 2 exercise
            //IEnumerable<Employee> managers = CreateManagers();
            //IEnumerable<ManagerDTO> managerDtos = Mapper.Map<IEnumerable<Employee>,
            //    IEnumerable<ManagerDTO>>(managers);

            //foreach (var man in managerDtos)
            //{
            //    Console.WriteLine(man.ToString());
            //}

            //InitializeDatabase();

            //IEnumerable<Employee> employees = CreateManagers();
            //SeedDatabase(employees);
            using (var context = new EmployeeCotext())
            {
                var employees = context.Employees
                    .Where(e => e.Birthday.Value.Year > 1990)
                    .OrderByDescending(e => e.Salary)
                    .ProjectTo<EmployeeDTO1>();

                foreach (var emp in employees)
                {
                    Console.WriteLine(emp.ToString());
                }
            }

        }

        private static void SeedDatabase(IEnumerable<Employee> employees)
        {
            using (EmployeeCotext context = new EmployeeCotext())
            {
                context.Employees.AddRange(employees);
                context.SaveChanges();
            }
            
        }

        private static void InitializeDatabase()
        {
            using(EmployeeCotext context = new EmployeeCotext())
            {
                context.Database.Initialize(true);
            }
        }

        private static void ConfigureAutomapping()
        {
            Mapper.Initialize(a =>
            {
                a.CreateMap<Employee, EmployeeDTO1>()
                    .ForMember(e => e.ManagerLastName,configExpresion => configExpresion.MapFrom(e => e.Manager.LastName));
                a.CreateMap<Employee, ManagerDTO>()
                .ForMember(dto => dto.SubordinatesCount, c => c.MapFrom(e => e.Subordinates.Count));
            });
           
            
        }
        private static IEnumerable<Employee> CreateManagers()
        {
            var managers = new List<Employee>();
            for (int i = 0; i < 3; i++)
            {
                var manager = new Employee()
                {
                    FirstName = "Pesho",
                    LastName = "Petrov",
                    Address = "Sofia, Tintiava 15",
                    Birthday = new DateTime(1993, 3, 2),
                    Subordinates = new List<Employee>(),
                    IsOnHolliday = false,
                    Manager = new Employee() { FirstName = "Ivan", LastName = "Ivanov" },
                    Salary = 200m
                };
                var employee1 = new Employee()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Salary = 250.20m,
                    Manager = manager
                };
                var employee2 = new Employee()
                {
                    FirstName = "Johny",
                    LastName = "Doing",
                    Salary = 270.20m,
                    Manager = manager
                };
                var employee3 = new Employee()
                {
                    FirstName = "Johnie",
                    LastName = "Doeble",
                    Salary = 350.20m,
                    Manager = manager
                };
                manager.Subordinates.Add(employee1);
                manager.Subordinates.Add(employee2);
                manager.Subordinates.Add(employee3);
                managers.Add(manager);
            }
            return managers;
        }
    }
}
