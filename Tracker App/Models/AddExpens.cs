//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tracker_App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AddExpens
    {
        public int id { get; set; }
        public int categId { get; set; }
        public float expenseAmount { get; set; }
        public System.DateTime date { get; set; }
        public string userEmail { get; set; }
    }
}
