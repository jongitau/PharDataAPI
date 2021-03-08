using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PharDataAPI.Controllers
{
    public class PharBillListController : ApiController
    {
      
        [HttpGet]
        [Route("api/PharBillList/{PatientID}/{LocationID}")]//{LocationID}/{BillID}")]
        public HttpResponseMessage Get(int PatientId,int LocationID)//(int PatientId,int LocationID, int BillID)

        {
            IQCareKAWEEntities1 entities = new IQCareKAWEEntities1();
            int? BillID = null;
            //int? LocationID = 762;
            return Request.CreateResponse((HttpStatusCode.OK), entities.pr_Billing_GetPatientsBilItems(LocationID, PatientId, BillID).ToList());
        }

    }
}
