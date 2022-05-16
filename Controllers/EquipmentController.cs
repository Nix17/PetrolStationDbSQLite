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
    public class EquipmentController
    {
        public List<Equipment> GetEquipmentsByFilters(string search = "", string field = "")
        {
            List<Equipment> equipments = null;

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    if (search == "")
                    {
                        equipments = db.Equipments.ToList();
                    }
                    else
                    {
                        var listLocal = db.Equipments.ToList();
                        switch (field)
                        {
                            case "common":
                                equipments = listLocal
                                    .Where(
                                        eq => eq.Name.ToLower().Contains(search.ToLower())
                                        || eq.Price.ToString().ToLower().Contains(search.ToLower())
                                        || eq.CreatedBy.ToLower().Contains(search.ToLower())
                                        || eq.UpdatedBy.ToLower().Contains(search.ToLower())
                                    ).ToList();
                                break;

                            case "name":
                                equipments = listLocal
                                    .Where(
                                        eq => eq.Name.ToLower().Contains(search.ToLower())
                                    ).ToList();
                                break;

                            case "price":
                                equipments = listLocal
                                    .Where(
                                        eq => eq.Price.ToString().ToLower().Contains(search.ToLower())
                                    ).ToList();
                                break;

                            default:
                                equipments = db.Equipments.ToList();
                                break;
                        }
                    }
                }
            }catch (Exception ex)
            {
                return null;
            }
            return equipments;
        }

        public bool SaveChangesSingleEquipment(string _user, Guid _guid, string _name, decimal _price)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    Equipment item = db.Equipments.FirstOrDefault(eq => eq.Id == _guid);
                    if(item != null)
                    {
                        item.Price = _price;
                        item.Name = _name;
                        item.UpdatedBy = _user;
                        item.UpdatedDate = DateTime.Now;

                        db.Equipments.Update(item);
                        db.SaveChanges();
                        result = true;
                    }
                }
            }catch (Exception ex)
            {
                return false;
            }

            return result;
        }

        public bool DeleteSingleEquipment(Guid _guid)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    Equipment item = db.Equipments.FirstOrDefault(eq => eq.Id == _guid);
                    if(item != null)
                    {
                        db.Equipments.Remove(item);
                        db.SaveChanges();

                        result = true;
                    }
                }
            }catch (Exception ex)
            {
                return false;
            }

            return result;
        }

        public int GetMaxInventoryNum()
        {
            int result = 0;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    result = db.Equipments.Max(eq => eq.InventoryNumber);
                }
            }catch (Exception ex)
            {
                return 0;
            }

            return result;
        }

        public bool AddNewEquipment(string _user, Equipment _item)
        {
            bool result = false;

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    _item.Id = Guid.NewGuid();
                    _item.CreatedBy = _user;
                    _item.CreatedDate = DateTime.Now;
                    _item.UpdatedBy = _user;
                    _item.UpdatedDate = DateTime.Now;

                    db.Equipments.Add(_item);
                    db.SaveChanges();

                    result=true;
                }
            }catch (Exception ex)
            {
                return false;
            }

            return result;
        }

        public Equipment GetSingleEquipmentById(Guid _guid)
        {
            Equipment equipment = null;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    equipment = db.Equipments.FirstOrDefault(eq => eq.Id == _guid);
                }
            }catch (Exception ex)
            {
                return null;
            }

            return equipment;
        }

        public List<Equipment> GetEquipmentsByStructureId(Guid _guid)
        {
            List<Equipment> results = null;

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    results = db.Equipments.Where(eq => eq.StructureId == _guid).ToList();
                }
            }catch (Exception ex)
            {
                return null;
            }

            return results;
        }
    }
}
