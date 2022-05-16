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
    [Table("structures")]
    public class Structure: BaseEntity
    {
        [Column("name", Order = 1)]
        public string Name { get; set; }

        [Column("square", Order = 2)]
        public decimal Square { get; set; }

        [Column("petrol_station_id", Order = 3)]
        public Guid PetrolStationId { get; set; }
        public PetrolStation PetrolStation { get; set; }
    }
}
