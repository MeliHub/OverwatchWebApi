//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OverwatchDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class INCIDENTHISTORY
    {
        public int incidentHistoryID { get; set; }
        public Nullable<int> reportIncidentID { get; set; }
        public string dateTime { get; set; }
        public string comment { get; set; }
        public Nullable<int> adminID { get; set; }
    }
}