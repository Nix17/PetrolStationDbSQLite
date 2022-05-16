using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetrolStationDB.Database.Models;
using PetrolStationDB.Services.Interfaces;
using Novacode;

namespace PetrolStationDB.Services
{
    public class WordService : IWordService
    {
        private StringBuilder GetPathForFile(string _fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string guidCode = Guid.NewGuid().ToString();
            string shortDate = DateTime.Now.ToShortDateString();

            StringBuilder filePath = new StringBuilder();

            filePath.Append(path + "\\" + _fileName + "_" + shortDate + "_" + guidCode + ".docx");

            return filePath;
        }

        public bool CreateDocEquipmentByEmployee(Dictionary<Employee, List<Equipment>> _dict, string _nameEmployee = "")
        {
            bool result = false;

            StringBuilder path = null;

            if (_nameEmployee == "")
            {
                path = this.GetPathForFile("Оборудование_по_сотруднику");
            }
            else
            {
                path = this.GetPathForFile(_nameEmployee + "_Оборудование");
            }

            try
            {
                if(_dict == null)
                {
                    throw new Exception();
                }

                using (var document = DocX.Create(path.ToString()))
                {
                    Employee employee = _dict.Keys.First();
                    string empName = "ФИО сотрудника: " + 
                        employee.LastName + " " + 
                        employee.FirstName + " " + 
                        employee.MiddleName + 
                        ", персональный номер = " + employee.PersonnelNumber;

                    document.InsertParagraph(empName);
                    document.InsertParagraph("Список оборудования:");
                    document.InsertParagraph();

                    if(_dict.Values.Count > 0)
                    {
                        int idx = 0;

                        var list = _dict.First().Value.ToList();
                        foreach(var item in list)
                        {
                            string strValue =
                                (idx + 1).ToString() + ". " + item.Name +
                                " (цена: " + Math.Round(item.Price, 2) +
                                "; инв. номер: " + item.InventoryNumber +
                                "; дата выпуска: " + item.DateOfRelease.ToShortDateString() + ").";
                            document.InsertParagraph(strValue);
                            document.InsertParagraph();
                            idx++;
                        }
                    }
                    document.Save();
                    result = true;
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public bool CreateDocListPetrolStationWithEquipment(Dictionary<PetrolStation, List<Equipment>> _dict)
        {
            bool result = false;
            StringBuilder path = this.GetPathForFile("Список_АЗС_с_оборудованием");

            try
            {
                if (_dict == null)
                {
                    throw new Exception();
                }

                using(var document = DocX.Create(path.ToString()))
                {
                    foreach(var item in _dict)
                    {
                        string psData = "АЗС: номер станции - " + item.Key.NumberStation + 
                            " (месторасположение: " + item.Key.Location.Replace(';', ',') + ")";
                        document.InsertParagraph(psData);
                        document.InsertParagraph("-------------------");

                        document.InsertParagraph("Список оборудования: ");
                        document.InsertParagraph();

                        int idx = 0;
                        foreach(var equipment in item.Value)
                        {
                            string strValue =
                                (idx + 1).ToString() + ". " + equipment.Name +
                                " (цена: " + Math.Round(equipment.Price, 2) +
                                "; инв. номер: " + equipment.InventoryNumber +
                                "; дата выпуска: " + equipment.DateOfRelease.ToShortDateString() + ").";
                            
                            document.InsertParagraph(strValue);
                            document.InsertParagraph();
                            idx++;
                        }
                        document.InsertParagraph("###############################");
                        document.InsertParagraph();
                        document.InsertParagraph();
                        document.InsertParagraph();
                    }
                    document.Save();
                    result = true;
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public void Dispose()
        {
        }
    }
}
