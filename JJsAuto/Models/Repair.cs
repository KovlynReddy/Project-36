//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JJsAuto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Repair
    {
        public int Id { get; set; }
        public Nullable<bool> Engine { get; set; }
        public Nullable<bool> Suspension { get; set; }
        public Nullable<bool> Transmission { get; set; }
        public Nullable<bool> Battery { get; set; }
        public Nullable<bool> Brakes { get; set; }
        public Nullable<bool> Radiator { get; set; }
        public Nullable<bool> Other { get; set; }
        public Nullable<decimal> Repair_Cost { get; set; }
    }
}
