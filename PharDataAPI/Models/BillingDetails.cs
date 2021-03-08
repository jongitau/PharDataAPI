using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharDataAPI.Models
{
    public class BillingDetails
    {
        public Nullable<int> BillID { get; set; }
        public int billItemID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public int LocationID { get; set; }
        public System.DateTime BillItemDate { get; set; }
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public int ItemType { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> PaymentType { get; set; }
        public Nullable<int> PaymentName { get; set; }
        public Nullable<decimal> SellingPrice { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int PaymentStatus { get; set; }
        public Nullable<bool> PayItem { get; set; }
        public int ServiceStatus { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public string CostCenterName { get; set; }
        public string ItemTypeName { get; set; }
        public Nullable<int> ItemSourceReferenceID { get; set; }
    }
}