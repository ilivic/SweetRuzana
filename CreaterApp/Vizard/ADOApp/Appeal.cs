//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vizard.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appeal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appeal()
        {
            this.AnswerAppeal = new HashSet<AnswerAppeal>();
        }
    
        public int id_Appeal { get; set; }
        public string Text { get; set; }
        public int User_id { get; set; }
        public System.DateTime DateAppeal { get; set; }
        public bool IsVisibli { get; set; }
        public string MediaElement { get; set; }
        public int isClose { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnswerAppeal> AnswerAppeal { get; set; }
        public virtual AppealCloseType AppealCloseType { get; set; }
        public virtual Users Users { get; set; }
    }
}
