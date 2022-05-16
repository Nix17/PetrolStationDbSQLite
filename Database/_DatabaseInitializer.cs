using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetrolStationDB.Database.Models;
using PetrolStationDB.Services;

namespace PetrolStationDB.Database
{
    public interface IDatabaseInitializer
    {
        void MySeed();
    }
    public class DatabaseInitializer: IDatabaseInitializer
    {
        private readonly _ContextDb _context;

        public DatabaseInitializer(_ContextDb context)
        {
            _context = context;
        }

        public void MySeed()
        {
            string str_ini_by = "Initializer";
            EncryptionText et = new EncryptionText();

            if (!_context.Users.Any())
            {
                var items = new User[]
                {
                    new User {
                        Id = Guid.NewGuid(),
                        Login = "root",
                        Password = et.ComputeSha256Hash("root"),
                        Role = "root",
                        CreatedBy = str_ini_by,
                        UpdatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Login = "admin",
                        Password = et.ComputeSha256Hash("admin"),
                        Role = "admin",
                        CreatedBy = str_ini_by,
                        UpdatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    },
                    new User
                    {
                        Id= Guid.NewGuid(),
                        Login = "user",
                        Password = et.ComputeSha256Hash("user"),
                        Role = "user",
                        CreatedBy = str_ini_by,
                        UpdatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    }
                };

                _context.Users.AddRange(items);
                _context.SaveChanges();
            }

            if (!_context.PetrolStationTypes.Any())
            {
                var items = new PetrolStationType[]
                {
                    new PetrolStationType
                    {
                        Id = Guid.NewGuid(),
                        TypeName = "КОНТЕЙНЕРНАЯ".ToUpper(),
                        CreatedBy = str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy= str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new PetrolStationType
                    {
                        Id = Guid.NewGuid(),
                        TypeName = "МОДУЛЬНАЯ".ToUpper(),
                        CreatedBy = str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy= str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new PetrolStationType
                    {
                        Id = Guid.NewGuid(),
                        TypeName = "БЛОЧНАЯ".ToUpper(),
                        CreatedBy = str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy= str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new PetrolStationType
                    {
                        Id = Guid.NewGuid(),
                        TypeName = "ПЕРЕДВИЖНАЯ".ToUpper(),
                        CreatedBy = str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy= str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new PetrolStationType
                    {
                        Id = Guid.NewGuid(),
                        TypeName = "ГАЗОВАЯ".ToUpper(),
                        CreatedBy = str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy= str_ini_by,
                        UpdatedDate = DateTime.Now
                    }
                };

                _context.PetrolStationTypes.AddRange(items);
                _context.SaveChanges();
            }

            if (!_context.PetrolStations.Any())
            {
                var types = _context.PetrolStationTypes.ToList();

                var items = new PetrolStation[]
                {
                    new PetrolStation
                    {
                        Id = Guid.NewGuid(),
                        NumberStation = 1,
                        Location = "Smolensk",
                        PetrolStationTypeId = types.Find(t => t.TypeName == "газовая".ToUpper()).Id,
                        CreatedBy= str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new PetrolStation
                    {
                        Id = Guid.NewGuid(),
                        NumberStation = 2,
                        Location = "Smolensk",
                        PetrolStationTypeId = types.Find(t => t.TypeName == "КОНТЕЙНЕРНАЯ".ToUpper()).Id,
                        CreatedBy= str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new PetrolStation
                    {
                        Id = Guid.NewGuid(),
                        NumberStation = 3,
                        Location = "Rudnya",
                        PetrolStationTypeId = types.Find(t => t.TypeName == "БЛОЧНАЯ".ToUpper()).Id,
                        CreatedBy= str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    }
                };

                _context.PetrolStations.AddRange(items);
                _context.SaveChanges();
            }

            if (!_context.Structures.Any())
            {
                var ps = _context.PetrolStations.ToList();
                var items = new Structure[]
                {
                    new Structure
                    {
                        Id = Guid.NewGuid(),
                        Name = "Здание оператора с торговым залом",
                        Square = 223.45M,
                        PetrolStationId = ps.Find(p => p.NumberStation == 1).Id,
                        CreatedBy = str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Structure
                    {
                        Id = Guid.NewGuid(),
                        Name = "Резервуарный парк",
                        Square = 120.0M,
                        PetrolStationId = ps.Find(p => p.NumberStation == 1).Id,
                        CreatedBy = str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Structure
                    {
                        Id = Guid.NewGuid(),
                        Name = "Навес над ТРК",
                        Square = 235.656M,
                        PetrolStationId = ps.Find(p => p.NumberStation == 2).Id,
                        CreatedBy = str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Structure
                    {
                        Id = Guid.NewGuid(),
                        Name = "Переходный навес к зданию оператора",
                        Square = 72.6M,
                        PetrolStationId = ps.Find(p => p.NumberStation == 3).Id,
                        CreatedBy = str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    }
                };

                _context.Structures.AddRange(items);
                _context.SaveChanges();
            }

            if (!_context.Employees.Any())
            {
                var ps = _context.PetrolStations.ToList();
                string defaultUrl = "https://secure.gravatar.com/avatar/833c2d4165b70f183a27744cfc123396?s=100&d=mm&r=g";
                var items = new Employee[]
                {
                    new Employee
                    {
                        Id= Guid.NewGuid(),
                        PersonnelNumber = 1,
                        LastName = "Александрова",
                        FirstName = "Екатерина",
                        MiddleName = "Витальевна",
                        PhotoUrl = defaultUrl,
                        PetrolStationId = ps.Find(p => p.NumberStation == 1).Id,
                        CreatedBy= str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy= str_ini_by,
                        UpdatedDate= DateTime.Now
                    },
                    new Employee
                    {
                        Id= Guid.NewGuid(),
                        PersonnelNumber = 2,
                        LastName = "Алиев",
                        FirstName = "Денис",
                        MiddleName = "Игоревич",
                        PhotoUrl = defaultUrl,
                        PetrolStationId = ps.Find(p => p.NumberStation == 1).Id,
                        CreatedBy= str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy= str_ini_by,
                        UpdatedDate= DateTime.Now
                    },
                    new Employee
                    {
                        Id= Guid.NewGuid(),
                        PersonnelNumber = 3,
                        LastName = "Ильин",
                        FirstName = "Александр",
                        MiddleName = "Валерьевич",
                        PhotoUrl = defaultUrl,
                        PetrolStationId = ps.Find(p => p.NumberStation == 1).Id,
                        CreatedBy= str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy= str_ini_by,
                        UpdatedDate= DateTime.Now
                    }
                    ,new Employee
                    {
                        Id= Guid.NewGuid(),
                        PersonnelNumber = 4,
                        LastName = "Новоселов",
                        FirstName = "Антон",
                        MiddleName = "Маркелович",
                        PhotoUrl = defaultUrl,
                        PetrolStationId = ps.Find(p => p.NumberStation == 2).Id,
                        CreatedBy= str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy= str_ini_by,
                        UpdatedDate= DateTime.Now
                    }
                    ,new Employee
                    {
                        Id= Guid.NewGuid(),
                        PersonnelNumber = 5,
                        LastName = "Павлов",
                        FirstName = "Филипп",
                        MiddleName = "Аркадьевич",
                        PhotoUrl = defaultUrl,
                        PetrolStationId = ps.Find(p => p.NumberStation == 2).Id,
                        CreatedBy= str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy= str_ini_by,
                        UpdatedDate= DateTime.Now
                    }
                    ,new Employee
                    {
                        Id= Guid.NewGuid(),
                        PersonnelNumber = 6,
                        LastName = "Шутов",
                        FirstName = "Руслан",
                        MiddleName = "Алексеевич",
                        PhotoUrl = defaultUrl,
                        PetrolStationId = ps.Find(p => p.NumberStation == 3).Id,
                        CreatedBy= str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy= str_ini_by,
                        UpdatedDate= DateTime.Now
                    },
                    new Employee
                    {
                        Id= Guid.NewGuid(),
                        PersonnelNumber = 7,
                        LastName = "Кева",
                        FirstName = "Татьяна",
                        MiddleName = "Владимировна",
                        PhotoUrl = defaultUrl,
                        PetrolStationId = ps.Find(p => p.NumberStation == 3).Id,
                        CreatedBy= str_ini_by,
                        CreatedDate= DateTime.Now,
                        UpdatedBy= str_ini_by,
                        UpdatedDate= DateTime.Now
                    }
                };

                _context.Employees.AddRange(items);
                _context.SaveChanges();
            }

            if (!_context.Equipments.Any())
            {
                var strucs = _context.Structures.ToList();
                var items = new Equipment[]
                {
                    new Equipment
                    {
                        Id = Guid.NewGuid(),
                        InventoryNumber = 1,
                        Name = "Топливораздаточные колонки (ТРК)",
                        Price = 25M,
                        DateOfRelease = DateTime.Now,
                        DateOfLastInventory = DateTime.Now,
                        StructureId = strucs.First(s => s.Name == "Здание оператора с торговым залом").Id,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Equipment
                    {
                        Id = Guid.NewGuid(),
                        InventoryNumber = 2,
                        Name = "Насосное оборудование",
                        Price = 122M,
                        DateOfRelease = DateTime.Now,
                        DateOfLastInventory = DateTime.Now,
                        StructureId = strucs.First(s => s.Name == "Резервуарный парк").Id,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Equipment
                    {
                        Id = Guid.NewGuid(),
                        InventoryNumber = 3,
                        Name = "Электронно-измерительное оборудование",
                        Price = 342M,
                        DateOfRelease = DateTime.Now,
                        DateOfLastInventory = DateTime.Now,
                        StructureId = strucs.First(s => s.Name == "Навес над ТРК").Id,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Equipment
                    {
                        Id = Guid.NewGuid(),
                        InventoryNumber = 4,
                        Name = "Автоматика для учета и отпуска топлива",
                        Price = 50M,
                        DateOfRelease = DateTime.Now,
                        DateOfLastInventory = DateTime.Now,
                        StructureId = strucs.First(s => s.Name == "Переходный навес к зданию оператора").Id,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    }
                };

                _context.Equipments.AddRange(items);
                _context.SaveChanges();
            }
        }
    }
}
