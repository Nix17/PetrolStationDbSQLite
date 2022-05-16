using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetrolStationDB.Database.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetrolStationDB.Database.Base
{
    public class AuditableEntity: IAuditableEntity
    {
        [Column("created_by", Order = 101)]
        [MaxLength(256)]
        public string CreatedBy { get; set; } = String.Empty;
        
        [Column("updated_by", Order = 103)]
        [MaxLength(256)]
        public string UpdatedBy { get; set; } = String.Empty;
        
        [Column("created_at", Order = 102)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        /*TypeName = "timestamp without time zone", */
        [Column("updated_at", Order = 104)]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
