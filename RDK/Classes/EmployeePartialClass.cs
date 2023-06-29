using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDK
{
    public partial class EmployeeTable
    {
        public string Fio
        {
            get 
            {
                if (Name == null && Patronymic == null)
                {
                    return Surname;
                }
                if (Patronymic == null)
                {
                    return Surname + " " + Name[0] + ".";
                }
                return Surname + " " + Name[0] + ". " + Patronymic[0] + ".";
            } 
        }

        public string SickLeave
        {
            get
            {
                string str = "";
                List<SickLeaveTable> list = SickLeaveTable.ToList();
                foreach (SickLeaveTable table in list)
                {
                    str += "с " + table.Start.ToString("dd.MM.yyyy") + " по " + table.End.ToString("dd.MM.yyyy") + "\n";
                }
                return str;
            }
        }
    }
}
