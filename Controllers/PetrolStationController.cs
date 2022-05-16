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
    public class PetrolStationController
    {
        public List<PetrolStationType> GetAllTypes(string search = "")
        {
            List<PetrolStationType> result = null;

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    if (search == "")
                    {
                        result = db.PetrolStationTypes.ToList();
                    }
                    else
                    {
                        var listLocal = db.PetrolStationTypes.ToList();
                        result = listLocal.Where(t => t.TypeName.ToLower().Contains(search.ToLower())).ToList();
                    }
                }
            }
            catch(Exception ex)
            {
                return null;
            }

            return result;
        }

        public string GetTypeNameForSinglePetrolStation(Guid _guid)
        {
            string typeName = "";

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    PetrolStationType type = db.PetrolStationTypes.FirstOrDefault(x => x.Id == _guid);
                    if(type != null)
                    {
                        typeName = type.TypeName;
                    }
                }
            }catch(Exception ex)
            {
                return "";
            }

            return typeName;
        }

        public int GetMaxNumberStation()
        {
            int maxNumberStation = 0;

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    if (db.PetrolStations.ToList().Count > 0)
                    {
                        maxNumberStation = db.PetrolStations.Max(p => p.NumberStation);
                    }
                }
            }
            catch(Exception ex)
            {
                return 0;
            }

            return maxNumberStation;
        }

        public bool AddNewPetrolStation(
            string _num,
            Guid _guidType,
            string _location,
            string _user
        )
        {
            bool result = false;

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    PetrolStation ps = new PetrolStation
                    {
                        Id = Guid.NewGuid(),
                        NumberStation = Convert.ToInt32(_num),
                        Location = _location,
                        PetrolStationTypeId = _guidType,
                        CreatedBy = _user,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = _user,
                        UpdatedDate = DateTime.Now
                    };

                    db.PetrolStations.Add(ps);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            
            return result;
        }

        public PetrolStation GetSinglePStation(Guid _id)
        {
            PetrolStation ps = null;

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    ps = db.PetrolStations.Single(p => p.Id == _id);
                }
            }
            catch(Exception ex)
            {
                return null;
            }

            return ps;
        }

        public List<PetrolStation> GetAllPetrolStations(string search = "", string field = "")
        {
            List<PetrolStation> list = null;

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    if(search == "")
                    {
                        list = db.PetrolStations.OrderBy(ps => ps.NumberStation).ToList();
                    }
                    else
                    {
                        var listLocal = db.PetrolStations.OrderBy(ps => ps.NumberStation).ToList();
                        switch (field)
                        {
                            case "common":
                                list = listLocal
                                    .Where(
                                        ps => ps.NumberStation.ToString().Contains(search.ToLower())
                                        || ps.Location.ToLower().Contains(search.ToLower())
                                        || ps.CreatedBy.ToLower().Contains(search.ToLower())
                                        || ps.UpdatedBy.ToLower().Contains(search.ToLower())
                                    ).OrderBy(ps => ps.NumberStation).ToList();
                                break;

                            case "numPStation":
                                list = listLocal
                                    .Where(
                                        ps => ps.NumberStation.ToString().Contains(search.ToLower())
                                    ).OrderBy(ps => ps.NumberStation).ToList();
                                break;

                            case "location":
                                list = listLocal
                                    .Where(
                                        ps => ps.Location.ToLower().Contains(search.ToLower())
                                    ).OrderBy(ps => ps.NumberStation).ToList();
                                break;

                            default:
                                list = db.PetrolStations.OrderBy(ps => ps.NumberStation).ToList();
                                break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                return null;
            }

            return list;
        }

        public bool DeletePetrolStationById(Guid _guid)
        {
            bool result = false;

            try
            {
                using (_ContextDb db = new _ContextDb())
                {
                    PetrolStation item = db.PetrolStations.FirstOrDefault(ps => ps.Id == _guid);

                    if(item != null)
                    {
                        db.PetrolStations.Remove(item);
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

        public PetrolStation GetPetrolStationCommonMaxPriceEquipments()
        {
            PetrolStation result = null;

            try
            {
                using(_ContextDb db = new _ContextDb())
                {
                    var list =
                        db.Structures
                        .Join(
                            db.PetrolStations,
                            st => st.PetrolStationId,
                            ps => ps.Id,
                            (st, ps) => new PetrolStationMaxPriceEquipment
                            {
                                Id = ps.Id,
                                StructureID = st.Id,
                                CommonMaxPriceEquipments = 0
                            });

                    var equipments = db.Equipments.ToList();
                    foreach (var item in list)
                    {
                        item.CommonMaxPriceEquipments = equipments.Where(x => x.StructureId == item.StructureID).Sum(x => x.Price);
                    }

                    //var max = list.Max(x => x.CommonMaxPriceEquipments);

                    List<decimal> decValues = new List<decimal>();
                    foreach (var val in list)
                    {
                        decValues.Add(val.CommonMaxPriceEquipments);
                    }

                    var max = decValues.Max();

                    var psItems = db.PetrolStations.ToList();
                    foreach (var item in list)
                    {
                        if(item.CommonMaxPriceEquipments == max)
                        {
                            result = psItems.FirstOrDefault(ps => ps.Id == item.Id);
                            break;
                        }
                    }
                }
            }catch(Exception ex)
            {
                return null;
            }

            return result;
        }
    }
}
