﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Template Producer.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFluent.Samples.AngularJs.Web.ApiControllers
{
    using System.Collections.Generic;
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class CustomerController : ApiController
    {
        // GET api/Customer
        
        public IEnumerable<Customer> Get()
        {
            return SoftFluent.Samples.AngularJs.CustomerCollection.LoadAll();
        }

        // POST api/Customer
        public HttpResponseMessage Post([FromBody]Customer value)
        {
            if (value == null || !value.Save())
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return Request.CreateResponse(HttpStatusCode.OK, value);
        }

        // PUT api/Customer
        public HttpResponseMessage Put([FromBody]Customer value)
        {
            if (value == null || !value.Save())
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return Request.CreateResponse(HttpStatusCode.OK, value);
        }
        // DELETE api/Customer/*ids
        public HttpResponseMessage Delete(string ids)
        {
            ids = ids.Replace('/', '|');
            SoftFluent.Samples.AngularJs.Customer value = SoftFluent.Samples.AngularJs.Customer.LoadByEntityKey(ids);
            if (value != null && value.Delete())
            {
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        // GET api/Customer/*ids
        public Customer Get(string ids)
        {
            ids = ids.Replace('/', '|');
            SoftFluent.Samples.AngularJs.Customer value = SoftFluent.Samples.AngularJs.Customer.LoadByEntityKey(ids);
            if (value == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return value;
        }
    }
}
