//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class urunler
    {
        public int id { get; set; }
        public string foto { get; set; }
        public string baslik { get; set; }
        public string usttbaslik { get; set; }
        public string icerik { get; set; }
        public bool aktif { get; set; }
        public Nullable<int> pasif { get; set; }
        public Nullable<int> sira { get; set; }
    }
}