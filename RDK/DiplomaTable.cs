//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RDK
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiplomaTable
    {
        public int IDEmployee { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public System.DateTime DateIssue { get; set; }
        public string Speciality { get; set; }
        public string Institution { get; set; }
        public string Profile { get; set; }
        public string Education { get; set; }
    
        public virtual EmployeeTable EmployeeTable { get; set; }
    }
}
