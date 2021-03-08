using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PharDataAPI.Models;
using System.Data.SqlClient;
using EMRDataAccess;


namespace PharDataAPI.Controllers
{
    public class PharOpenBillsController : ApiController
    {

        [HttpGet]
        [Route("api/PharOpenBills/{LocationID}")]//{LocationID}")]
        public HttpResponseMessage Get(int LocationID)
        
        {
            string password = null;
            string filter = null;
            DateTime? DateFrom = DateTime.Today;// '2020-12-01 00:00:00';
            DateTime? DateTo = DateTime.Now;// '2020-12-01 23:59:59';

            IQCareKAWEEntities entities = new IQCareKAWEEntities();
            return Request.CreateResponse((HttpStatusCode.OK),entities.pr_Billing_getOpenBills(LocationID, password, filter, DateFrom, DateTo).ToList());
        }

    }
}
