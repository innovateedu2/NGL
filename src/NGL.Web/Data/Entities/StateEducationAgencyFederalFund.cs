//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NGL.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class StateEducationAgencyFederalFund
    {
        public StateEducationAgencyFederalFund()
        {
    		this.Id = System.Guid.NewGuid();
    		this.LastModifiedDate = System.DateTime.Now;
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int StateEducationAgencyId { get; set; }
        public int FiscalYear { get; set; }
        public Nullable<decimal> FederalProgramsFundingAllocation { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StateEducationAgencyFederalFundsIdentity { get; set; }
    
        public virtual StateEducationAgency StateEducationAgency { get; set; }
    }
}
