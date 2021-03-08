using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace PharDataAPI.Controllers
{
    public class UsersController : ApiController
    {
        public IEnumerable<mst_User> Get()
        {
            using (IQCareKAWEEntities1 entities = new IQCareKAWEEntities1()) 
            {
                return entities.mst_User.ToList();
            }
        }
        
    }
}
