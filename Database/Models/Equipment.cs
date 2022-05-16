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
    // Оборудование
    [Table("equipment")]
    public class Equipment: BaseEntity
    {
        [Column("inventory_number", Order = 1)]
        public int InventoryNumber { get; set; }

        [Column("name", Order = 2)]
        public string Name { get; set; }

        [Column("price", Order = 3)]
        public decimal Price { get; set; }

        [Column("date_of_release", Order = 4)]
        public DateTime DateOfRelease { get; set; }

        [Column("date_of_last_inventory", Order = 5)]
        public DateTime DateOfLastInventory { get; set; }

        [Column("structure_id", Order = 5)]
        public Guid StructureId { get; set; }
        public Structure Structure { get; set; }
    }
}
