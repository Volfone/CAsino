//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAsino.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phots
    {
        public int ID_Phot { get; set; }
        public int User_ID { get; set; }
        public string path { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
