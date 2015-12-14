﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sperience
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SperienceEntities : DbContext
    {
        public SperienceEntities()
            : base("name=SperienceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Stage> Stages { get; set; }
        public virtual DbSet<SubjectAction> SubjectActions { get; set; }
        public virtual DbSet<SubjectActionChecklist> SubjectActionChecklists { get; set; }
        public virtual DbSet<SubjectActionExpense> SubjectActionExpenses { get; set; }
        public virtual DbSet<SubjectCategory> SubjectCategories { get; set; }
        public virtual DbSet<SubjectDocument> SubjectDocuments { get; set; }
        public virtual DbSet<SubjectHeader> SubjectHeaders { get; set; }
        public virtual DbSet<SubjectMarketChannel> SubjectMarketChannels { get; set; }
        public virtual DbSet<SubjectNote> SubjectNotes { get; set; }
        public virtual DbSet<SubjectRating> SubjectRatings { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerClassification> CustomerClassifications { get; set; }
        public virtual DbSet<CustomerContact> CustomerContacts { get; set; }
        public virtual DbSet<CustomerCreditLine> CustomerCreditLines { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }
        public virtual DbSet<ManufacturerProfile> ManufacturerProfiles { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SolutionLookup> SolutionLookups { get; set; }
        public virtual DbSet<Tenant> Tenants { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<RoleAccess> RoleAccesses { get; set; }
        public virtual DbSet<TimeDimension> TimeDimensions { get; set; }
        public virtual DbSet<vwSubjectType> vwSubjectTypes { get; set; }
        public virtual DbSet<vwBudgetaryAllocation> vwBudgetaryAllocations { get; set; }
        public virtual DbSet<vwDateType> vwDateTypes { get; set; }
    }
}