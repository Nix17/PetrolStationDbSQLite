using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetrolStationDB.Database.Base;

namespace PetrolStationDB.Database.Base
{
    public class BaseEntity: AuditableEntity
    {
        [Column("id", Order = 0)]
        [Key]
        public Guid Id { get; set; }
    }
}
