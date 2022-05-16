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
    public class StructureController
    {
        public List<Structure> GetAllStructuresWithFilter(string search = "", string field = "")
        {
            List<Structure> structuresList = null;

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    if (search == "")
                    {
                        structuresList = db.Structures.ToList();
                    }
                    else
                    {
                        var listLocal = db.Structures.ToList();
                        switch (field)
                        {
                            case "common":
                                structuresList = listLocal
                                    .Where(
                                        s => s.Name.ToLower().Contains(search.ToLower())
                                        || s.Square.ToString().ToLower().Contains(search.ToLower())
                                        || s.CreatedBy.ToLower().Contains(search.ToLower())
                                        || s.UpdatedBy.ToLower().Contains(search.ToLower())
                                    ).ToList();
                                break;

                            case "name":
                                structuresList = listLocal
                                    .Where(
                                        s => s.Name.ToLower().Contains(search.ToLower())
                                    ).ToList();
                                break;

                            case "square":
                                structuresList = listLocal
                                    .Where(
                                        s => s.Square.ToString().Contains(search.ToLower())
                                    ).ToList();
                                break;

                            default:
                                structuresList = db.Structures.ToList();
                                break;
                        }
                    }
                }
            }catch (Exception ex)
            {
                return null;
            }
            return structuresList;
        }

        public int GetCountEquipmentsForStructure(Guid _guid)
        {
            int count = 0;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    count = db.Equipments.Count(eq => eq.StructureId == _guid);
                }
            }catch (Exception ex)
            {
                return 0;
            }

            return count;
        }

        public bool SaveSingleStructure(string _user, Guid _guid, string _name, decimal _square)
        {
            bool result = false;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    Structure item = db.Structures.FirstOrDefault(st => st.Id == _guid);
                    if (item != null)
                    {
                        item.Name = _name;
                        item.Square = _square;
                        item.UpdatedBy = _user;
                        item.UpdatedDate = DateTime.Now;

                        db.Structures.Update(item);
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

        public bool DeleteSingleStructure(Guid _guid)
        {
            bool delete = false;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    Structure item = db.Structures.FirstOrDefault(st => st.Id == _guid);

                    if(item != null)
                    {
                        db.Structures.Remove(item);
                        db.SaveChanges();
                        delete = true;
                    }
                }
            }catch (Exception ex)
            {
                return false;
            }

            return delete;
        }

        public bool AddNewStructure(string _user, string _name, decimal _square, Guid _petrolStationId)
        {
            bool result = false;

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    Guid _guid = Guid.NewGuid();
                    Structure item = new Structure
                    {
                        Id = _guid,
                        Name = _name,
                        Square = _square,
                        PetrolStationId = _petrolStationId,
                        CreatedBy = _user,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = _user,
                        UpdatedDate = DateTime.Now
                    };

                    db.Structures.Add(item);
                    db.SaveChanges();
                    result = true;
                }
            }catch (Exception ex)
            {
                return false;
            }

            return result;
        }

        public Structure GetSingleStructure(Guid _guid)
        {
            Structure structure = null;

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    structure = db.Structures.FirstOrDefault(x => x.Id == _guid);
                    return structure;
                }
            }catch (Exception ex)
            {
                return null;
            }

            return structure;
        }

        public List<Guid> GetStructureIdByPetrolStationId(Guid _guid)
        {
            List<Guid> result = new List<Guid>();

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    var structures = db.Structures.Where(x => x.PetrolStationId == _guid).ToList();

                    if(structures != null && structures.Count > 0)
                    {
                        foreach (var item in structures)
                        {
                            result.Add(item.Id);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return result;
        }
    }
}
