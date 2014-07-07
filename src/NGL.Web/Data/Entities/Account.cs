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
    
    public partial class Account
    {
        public Account()
        {
    		this.Id = System.Guid.NewGuid();
    		this.LastModifiedDate = System.DateTime.Now;
    		this.CreateDate = System.DateTime.Now;
            this.AccountCodes = new HashSet<AccountCode>();
            this.Actuals = new HashSet<Actual>();
            this.Budgets = new HashSet<Budget>();
            this.ContractedStaffs = new HashSet<ContractedStaff>();
            this.Payrolls = new HashSet<Payroll>();
        }
    
        public int EducationOrganizationId { get; set; }
        public string AccountNumber { get; set; }
        public int FiscalYear { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int AccountIdentity { get; set; }
    
        public virtual EducationOrganization EducationOrganization { get; set; }
        public virtual ICollection<AccountCode> AccountCodes { get; set; }
        public virtual ICollection<Actual> Actuals { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<ContractedStaff> ContractedStaffs { get; set; }
        public virtual ICollection<Payroll> Payrolls { get; set; }
    }
}
