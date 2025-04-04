using ManagerCRUD.Models;
using System.Collections.Generic;
using System;

namespace ManagerCRUD.Services.IServices
{
    public interface IManagerService
    {
        string AddManager(Manager manager);
        string UpdateManager(Manager manager);
        string DeleteManager(Guid id);
        List<Manager> GetAllManagers();
        Manager GetManagerById(Guid id);
    }
}
