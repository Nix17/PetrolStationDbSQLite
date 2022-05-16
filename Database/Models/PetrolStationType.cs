using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetrolStationDB.Database.Base;

namespace PetrolStationDB.Database.Models
{
    [Table("petrol_station_type")]
    public class PetrolStationType : BaseEntity
    {
        [Column("type_name", Order = 1)]
        public string TypeName { get; set; }
    }
}
