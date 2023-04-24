using EF_MWWM_DEMO.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MWWM_DEMO.Model
{
    public static class DataWorker
    {
        // создать отдел
        public static string CreateDepartment(string name)
        {
            string result = "Уже существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли отдел
                bool checkIsExist = db.Departments.Any(el => el.Name == name);
                if(!checkIsExist)
                {
                    Department newDepartment = new Department {Name = name};
                    db.Departments.Add(newDepartment);
                    db.SaveChanges();
                    result = "Сделано!";
                }
                return result;
            }
        }
        // создать позицию
        public static string CreatePosition(string name, decimal salary, int maxNumber, Department department)
        {
            string result = "Уже существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли позиция
                bool checkIsExist = db.Position.Any(el => el.Name == name && el.Salary == salary);
                if (!checkIsExist)
                {
                    Position newPosition = new Position 
                    {
                        Name = name,
                        Salary = salary,
                        MaxNamber = maxNumber,
                        DepartmentId = department.Id,
                    };
                    db.Position.Add(newPosition);
                    db.SaveChanges();
                    result = "Сделано!";
                }
                return result;
            }
        }
        // создать сотрудников

        // удаление отдела
        // удаление позиции
        // удаление сотрудников

        // редактирование отдела
        // редактирование позиции
        // редактирование сотрудников
    }
}
