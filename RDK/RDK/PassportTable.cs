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
    
    public partial class PassportTable
    {
        public int IDEmployee { get; set; }
        public int Series { get; set; }
        public int Number { get; set; }
        public System.DateTime DateIssue { get; set; }
        public int DivisionCode { get; set; }
        public string Issued { get; set; }
        public string PlaceRegistration { get; set; }
    
        public virtual EmployeeTable EmployeeTable { get; set; }
    }
}
