﻿using Orkidea.MH.WebMiddle.Business;
using Orkidea.MH.WebMiddle.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Orkidea.MH.WebMiddle.WebAPI.Controllers
{
    public class ColorController : ApiController
    {
        // GET: api/Color
        public IEnumerable<Color> Get()
        {
            return BizColor.GetList();
        }

        //// GET: api/Color/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Color
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Color/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Color/5
        //public void Delete(int id)
        //{
        //}
    }
}
