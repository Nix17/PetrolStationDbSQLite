using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetrolStationDB.Database.Base;
using PetrolStationDB.Database.Models;

namespace PetrolStationDB.Database.Models
{
    public class MaterialLiability: BaseEntity
    {
        [Column("employee_id", Order = 1)]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Column("equipment_id", Order = 2)]
        public Guid EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
    }
}
