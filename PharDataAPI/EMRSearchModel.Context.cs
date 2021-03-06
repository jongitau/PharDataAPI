//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PharDataAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class IQCareKAWEEntities1 : DbContext
    {
        public IQCareKAWEEntities1()
            : base("name=IQCareKAWEEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<mst_User> mst_User { get; set; }
    
        public virtual ObjectResult<pr_Billing_GetPatientsBilItems_Result> pr_Billing_GetPatientsBilItems(Nullable<int> locationID, Nullable<int> patientID, Nullable<int> billID)
        {
            var locationIDParameter = locationID.HasValue ?
                new ObjectParameter("LocationID", locationID) :
                new ObjectParameter("LocationID", typeof(int));
    
            var patientIDParameter = patientID.HasValue ?
                new ObjectParameter("PatientID", patientID) :
                new ObjectParameter("PatientID", typeof(int));
    
            var billIDParameter = billID.HasValue ?
                new ObjectParameter("BillID", billID) :
                new ObjectParameter("BillID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_Billing_GetPatientsBilItems_Result>("pr_Billing_GetPatientsBilItems", locationIDParameter, patientIDParameter, billIDParameter);
        }
    
        public virtual ObjectResult<pr_Billing_GetPatientsBilItems_Result> EMRSearch(Nullable<int> locationID, Nullable<int> patientID, Nullable<int> billID)
        {
            var locationIDParameter = locationID.HasValue ?
                new ObjectParameter("LocationID", locationID) :
                new ObjectParameter("LocationID", typeof(int));
    
            var patientIDParameter = patientID.HasValue ?
                new ObjectParameter("PatientID", patientID) :
                new ObjectParameter("PatientID", typeof(int));
    
            var billIDParameter = billID.HasValue ?
                new ObjectParameter("BillID", billID) :
                new ObjectParameter("BillID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_Billing_GetPatientsBilItems_Result>("EMRSearch", locationIDParameter, patientIDParameter, billIDParameter);
        }
    
        public virtual ObjectResult<pr_Billing_getOpenBills_Result> pr_Billing_getOpenBills(Nullable<int> locationID, string password, string filter, Nullable<System.DateTime> dateFrom, Nullable<System.DateTime> dateTo)
        {
            var locationIDParameter = locationID.HasValue ?
                new ObjectParameter("LocationID", locationID) :
                new ObjectParameter("LocationID", typeof(int));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var filterParameter = filter != null ?
                new ObjectParameter("filter", filter) :
                new ObjectParameter("filter", typeof(string));
    
            var dateFromParameter = dateFrom.HasValue ?
                new ObjectParameter("DateFrom", dateFrom) :
                new ObjectParameter("DateFrom", typeof(System.DateTime));
    
            var dateToParameter = dateTo.HasValue ?
                new ObjectParameter("DateTo", dateTo) :
                new ObjectParameter("DateTo", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_Billing_getOpenBills_Result>("pr_Billing_getOpenBills", locationIDParameter, passwordParameter, filterParameter, dateFromParameter, dateToParameter);
        }
    
        public virtual ObjectResult<pr_Billing_getOpenBills1_Result> pr_Billing_getOpenBills1(Nullable<int> locationID, string password, string filter, Nullable<System.DateTime> dateFrom, Nullable<System.DateTime> dateTo)
        {
            var locationIDParameter = locationID.HasValue ?
                new ObjectParameter("LocationID", locationID) :
                new ObjectParameter("LocationID", typeof(int));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var filterParameter = filter != null ?
                new ObjectParameter("filter", filter) :
                new ObjectParameter("filter", typeof(string));
    
            var dateFromParameter = dateFrom.HasValue ?
                new ObjectParameter("DateFrom", dateFrom) :
                new ObjectParameter("DateFrom", typeof(System.DateTime));
    
            var dateToParameter = dateTo.HasValue ?
                new ObjectParameter("DateTo", dateTo) :
                new ObjectParameter("DateTo", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_Billing_getOpenBills1_Result>("pr_Billing_getOpenBills1", locationIDParameter, passwordParameter, filterParameter, dateFromParameter, dateToParameter);
        }
    }
}
