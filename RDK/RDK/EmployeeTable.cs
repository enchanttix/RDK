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
    
    public partial class EmployeeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeTable()
        {
            this.SickLeaveTable = new HashSet<SickLeaveTable>();
        }
    
        public int IDEmployee { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public System.DateTime DateBirth { get; set; }
        public int Snils { get; set; }
        public int Inn { get; set; }
        public System.DateTime DateEmployment { get; set; }
        public Nullable<int> Number { get; set; }
    
        public virtual DiplomaTable DiplomaTable { get; set; }
        public virtual PassportTable PassportTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SickLeaveTable> SickLeaveTable { get; set; }
    }
}
