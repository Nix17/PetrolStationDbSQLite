using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetrolStationDB.Database;
using PetrolStationDB.Database.Models;
using PetrolStationDB.Services;
using Microsoft.EntityFrameworkCore;

namespace PetrolStationDB.Controllers
{
    public class MaterialLiabilityController
    {
        public List<MaterialLiability> GetMaterialLiabilities()
        {
            List<MaterialLiability> materialLiabilities = null;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    materialLiabilities = db.MaterialLiabilitys.ToList();
                }
            }catch(Exception ex)
            {
                return null;
            }

            return materialLiabilities;
        }

        public bool AddNewMaterialLiability(string _user, MaterialLiability item)
        {
            bool result = false;

            try
            { 
                using (_ContextDb db = new _ContextDb())
                {
                    item.Id = Guid.NewGuid();
                    item.CreatedBy = _user;
                    item.CreatedDate = DateTime.Now;
                    item.UpdatedBy = _user;
                    item.UpdatedDate = DateTime.Now;

                    db.MaterialLiabilitys.Add(item);
                    db.SaveChanges();
                    result = true;
                }
            }catch(Exception ex)
            {
                return false;
            }
            return result;
        }

        public bool DeleteMaterialLiability(Guid _guid)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    MaterialLiability item = db.MaterialLiabilitys.FirstOrDefault(x => x.Id == _guid);
                    if(item != null)
                    {
                        db.MaterialLiabilitys.Remove(item);
                        db.SaveChanges();
                        result = true;
                    }
                }
            }catch(Exception ex)
            {
                return false;
            }

            return result;
        }

        public List<Guid> GetEquipmentsIdByEmployeeId(Guid _employeeId)
        {
            List<Guid> result = new List<Guid>();

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    var list = db.MaterialLiabilitys.Where(x => x.EmployeeId == _employeeId).ToList();
                    if(list != null && list.Count > 0)
                    {
                        foreach(var item in list)
                        {
                            result.Add(item.EquipmentId);
                        }
                    }
                }
            }
            catch
            {
                return null;
            }

            return result;
        }
    }
}
