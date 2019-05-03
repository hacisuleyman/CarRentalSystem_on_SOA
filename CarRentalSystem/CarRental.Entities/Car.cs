//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRental.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        public int carID { get; set; }
        public Nullable<int> markID { get; set; }
        public Nullable<int> modelID { get; set; }
        public Nullable<int> companyID { get; set; }
        public Nullable<bool> rentalStatus { get; set; }
    
        public virtual CarInformation CarInformation { get; set; }
        public virtual Company Company { get; set; }
        public virtual Mark Mark { get; set; }
        public virtual Model Model { get; set; }
    }
}