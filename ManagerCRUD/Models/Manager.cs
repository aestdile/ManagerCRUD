using System;

namespace ManagerCRUD.Models
{
    public class Manager
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
