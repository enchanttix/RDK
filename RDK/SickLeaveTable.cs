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
    
    public partial class SickLeaveTable
    {
        public int IDSickLeave { get; set; }
        public int IDEmployee { get; set; }
        public System.DateTime Start { get; set; }
        public System.DateTime End { get; set; }
    
        public virtual EmployeeTable EmployeeTable { get; set; }
    }
}
