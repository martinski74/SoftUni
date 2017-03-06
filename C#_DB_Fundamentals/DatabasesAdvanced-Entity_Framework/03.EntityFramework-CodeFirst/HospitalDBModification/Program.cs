
using HospitalDBModification.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalDBModification.Models;
using HaspitalDatabase.Models;

namespace HospitalDBModification
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new HospitalDBModificationCtx();
            using (ctx)
            {
                ctx.Database.Initialize(true);

                Doctor doc = new Doctor()
                {
                    Name = "Dr.Dolitul",
                    Specialty = "Prevetionalist"
                };

                Patient patient = new Patient()
                {
                    FirstName = "Petar",
                    LastName = "Petrov",
                    Address = "Sofia",
                    BirthDate = new DateTime(1989, 10, 9),
                    Email = "petar@sdf.bg",
                    HasInsurance = true
                };
                Medicament medicament = new Medicament()
                {
                    Name = "Busculisin"
                };

                Visitation visit = new Visitation()
                {
                    Date = new DateTime(2017, 02, 14),
                    Comment = "Today is better than yesterday!"
                };
                Diagnose diagn = new Diagnose()
                {
                    Name = "Laringitis acuta!",
                    Comment = "Dr.Oh Boli"
                };

                ctx.Patients.Add(patient);
                ctx.Doctors.Add(doc);
                patient.Medicaments.Add(medicament);
                patient.Diagnoses.Add(diagn);
                patient.Visitations.Add(visit);
                ctx.SaveChanges();
            }

        }
    }
}
