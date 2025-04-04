using System;
using ManagerCRUD.Models;
using ManagerCRUD.Services;
using ManagerCRUD.Services.IServices;

namespace ManagerCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            IManagerService managerService = new ManagerService();

            while (true)
            {
                Console.WriteLine("1. Add Manager");
                Console.WriteLine("2. Delete Manager");
                Console.WriteLine("3. Update Manager");
                Console.WriteLine("4. Get Manager By Id");
                Console.WriteLine("5. Get All Managers");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(managerService.AddManager(new Manager()));
                        break;
                    case 2:
                        Console.WriteLine("Enter Manager ID to delete:");
                        Guid deleteId = Guid.Parse(Console.ReadLine());
                        Console.WriteLine(managerService.DeleteManager(deleteId));
                        break;
                    case 3:
                        Console.WriteLine("Enter Manager ID to update:");
                        Guid updateId = Guid.Parse(Console.ReadLine());
                        Manager existingManager = managerService.GetManagerById(updateId);
                        if (existingManager != null)
                        {
                            Console.WriteLine(managerService.UpdateManager(existingManager));
                        }
                        else
                        {
                            Console.WriteLine("Manager Not Found");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Manager ID:");
                        Guid searchId = Guid.Parse(Console.ReadLine());
                        Manager foundManager = managerService.GetManagerById(searchId);
                        if (foundManager != null)
                        {
                            Console.WriteLine($"Name: {foundManager.Name}, Department: {foundManager.Department}, Email: {foundManager.Email}, PhoneNumber: {foundManager.PhoneNumber}, Adress: {foundManager.Address}, Salary: {foundManager.Salary}, HireDate: {foundManager.HireDate}, Date of Birth: {foundManager.DateOfBirth}");
                        }
                        else
                        {
                            Console.WriteLine("Manager Not Found");
                        }
                        break;
                    case 5:
                        var managers = managerService.GetAllManagers();
                        if (managers.Count > 0)
                        {
                            foreach (var manager in managers)
                            {
                                Console.WriteLine($"Name: {manager.Name}, Department: {manager.Department}, Email: {manager.Email}, PhoneNumber: {manager.PhoneNumber}, Adress: {manager.Address}, Salary: {manager.Salary}, HireDate: {manager.HireDate}, Date of Birth: {manager.DateOfBirth}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Managers Available");
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
