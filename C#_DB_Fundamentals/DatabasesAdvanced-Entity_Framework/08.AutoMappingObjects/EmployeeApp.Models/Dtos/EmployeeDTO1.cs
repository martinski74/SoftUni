namespace EmployeeApp.Models.Dtos
{
    //Used for 03.exersice Projrction
    public class EmployeeDTO1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string ManagerLastName { get; set; }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} - Manager: {this.ManagerLastName ?? "[no manager]"}";
        }
    }
}
