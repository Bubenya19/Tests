//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tests.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sostav
    {
        public int idSostav { get; set; }
        public Nullable<int> idOrder { get; set; }
        public Nullable<int> idProduct { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Product Product { get; set; }
    }
}
