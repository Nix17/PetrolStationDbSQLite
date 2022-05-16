using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetrolStationDB.Database.Models;

namespace PetrolStationDB.Services.Interfaces
{
    public interface IWordService : IDisposable
    {
        bool CreateDocEquipmentByEmployee(Dictionary<Employee, List<Equipment>> _dict, string _nameEmployee = "");
        bool CreateDocListPetrolStationWithEquipment(Dictionary<PetrolStation, List<Equipment>> _dict);
    }
}
