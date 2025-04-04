using System;

namespace ManagerCRUD.Models
{
    public class Manager
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
    }
}
