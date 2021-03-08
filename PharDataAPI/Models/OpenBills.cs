using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharDataAPI.Models
{
    public class OpenBills
    {
        //define public properties of the class basically the rows expected to be returned from DB
        public Nullable<int> PatientID { get; set; }
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public System.DateTime DOB { get; set; }
        public Nullable<decimal> BillAmount { get; set; }
        public Nullable<decimal> OutStandingAmount { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
    }
}