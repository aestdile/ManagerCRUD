using System.Collections.Generic;
using System;
using ManagerCRUD.Models;
using ManagerCRUD.Services.IServices;

namespace ManagerCRUD.Services
{
    public class ManagerService : IManagerService
    {
        public List<Manager> Managers { get; set; } = new List<Manager>();

        public string AddManager(Manager manager)
        {
            Console.Write("Enter Name: ");
            manager.Name = Console.ReadLine();
            Console.Write("Enter Department: ");
            manager.Department = Console.ReadLine();
            Console.Write("Enter Email: ");
            manager.Email = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            manager.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Address: ");
            manager.Address = Console.ReadLine();
            Console.Write("Enter Salary: ");
            manager.Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Hire Date (yyyy-mm-dd): ");
            manager.HireDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter Date of Birth (yyyy-mm-dd): ");
            manager.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            manager.Id = Guid.NewGuid(); 
            Managers.Add(manager);
            return "Manager Added Successfully";
        }

        public string DeleteManager(Guid id)
        {
            Manager manager = Managers.Find(x => x.Id == id);
            if (manager != null)
            {
                Managers.Remove(manager);
                return "Manager Deleted Successfully";
            }
            return "Manager Not Found";
        }

        public List<Manager> GetAllManagers()
        {
            return Managers;
        }

        public Manager GetManagerById(Guid id)
        {
            Manager manager = Managers.Find(x => x.Id == id);
            if (manager != null)
            {
                return manager;
            }
            else
            {
                return null;
            }
        }

        public string UpdateManager(Manager manager)
        {
            Manager existingManager = Managers.Find(x => x.Id == manager.Id);
            if (existingManager != null)
            {
                Console.Write("Enter Name: ");
                existingManager.Name = Console.ReadLine();
                Console.Write("Enter Department: ");
                existingManager.Department = Console.ReadLine();
                Console.Write("Enter Email: ");
                existingManager.Email = Console.ReadLine();
                Console.Write("Enter Phone Number: ");
                existingManager.PhoneNumber = Console.ReadLine();
                Console.Write("Enter Address: ");
                existingManager.Address = Console.ReadLine();
                Console.Write("Enter Salary: ");
                existingManager.Salary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Hire Date (yyyy-mm-dd): ");
                existingManager.HireDate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter Date of Birth (yyyy-mm-dd): ");
                existingManager.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                existingManager.Id = manager.Id;
                return "Manager Updated Successfully";
            }
            return "Manager Not Found";
        }
    }
}
