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
    [Table("employee")]
    public class Employee: BaseEntity
    {
        [Column("personnel_number", Order = 1)]
        public int PersonnelNumber { get; set; }

        [Column("last_name", Order = 2)]
        public string LastName { get; set; }

        [Column("first_name", Order = 3)]
        public string FirstName { get; set; }

        [Column("middle_name", Order = 4)]
        public string MiddleName { get; set; }

        [Column("photo_url", Order = 5)]
        public string PhotoUrl { get; set; }

        [Column("petrol_station_id", Order = 6)]
        public Guid PetrolStationId { get; set; }
        public PetrolStation PetrolStation { get; set; }
    }

/*    [NotMapped]
    public class EmployeeResource : Employee
    {
        public int NumberStation { get; set; }
    }*/
}
