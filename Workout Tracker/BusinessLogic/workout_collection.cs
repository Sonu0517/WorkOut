//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessLogic
{
    using System;
    using System.Collections.Generic;
    
    public partial class workout_collection
    {
        public string workout_title { get; set; }
        public string workout_note { get; set; }
        public Nullable<double> calories_burn_per_min { get; set; }
        public Nullable<int> category_id { get; set; }
        public int workout_id { get; set; }
    
        public virtual workout_category workout_category { get; set; }
    }
}
