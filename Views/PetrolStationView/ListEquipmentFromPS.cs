using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetrolStationDB.Database;
using PetrolStationDB.Database.Models;
using PetrolStationDB.Controllers;

namespace PetrolStationDB.Views.PetrolStationView
{
    public partial class ListEquipmentFromPS : Form
    {
        Guid petrolStationGuid = Guid.Empty;
        StructureController structureController = null;
        EquipmentController equipmentController = null;
        public ListEquipmentFromPS(Guid _guid, string _psName)
        {
            petrolStationGuid = _guid;
            this.Text = _psName;
            structureController = new StructureController();
            equipmentController = new EquipmentController();
            InitializeComponent();
        }

        private void VoidDataGridView()
        {
            dataListEquipPsGV.Rows.Clear();
            dataListEquipPsGV.Columns.Clear();

            dataListEquipPsGV.Columns.Add("resultCol", "Нет данных");
            dataListEquipPsGV.Rows.Add();
            dataListEquipPsGV[0, 0].Value = "У данной АЗС не имеется оборудования";
        }

        private void ListEquipmentFromPS_Load(object sender, EventArgs e)
        {
            List<Guid> structureGuids = structureController.GetStructureIdByPetrolStationId(petrolStationGuid);
            if(structureGuids != null && structureGuids.Count > 0)
            {
                List<Equipment> equipmentItems = new List<Equipment>();

                foreach (var item in structureGuids)
                {
                    var equipmentResults = equipmentController.GetEquipmentsByStructureId(item);
                    if(equipmentResults != null && equipmentResults.Count > 0)
                    {
                        foreach (var equipment in equipmentResults)
                        {
                            equipmentItems.Add(equipment);
                        }
                    }
                }

                if(equipmentItems != null && equipmentItems.Count > 0)
                {
                    dataListEquipPsGV.Rows.Clear();
                    for(int i = 0; i < equipmentItems.Count; i++)
                    {
                        dataListEquipPsGV.Rows.Add();
                        dataListEquipPsGV[0, i].Value = i + 1;
                        dataListEquipPsGV[1, i].Value = equipmentItems[i].InventoryNumber;
                        dataListEquipPsGV[2, i].Value = equipmentItems[i].Name;
                    }
                }
                else
                {
                    VoidDataGridView();
                }
            }
            else
            {
                VoidDataGridView();
            }
        }
    }
}
