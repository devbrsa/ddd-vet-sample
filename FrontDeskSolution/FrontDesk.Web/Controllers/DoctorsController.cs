﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using FrontDesk.Web.Models;

namespace FrontDesk.Web.Controllers
{
    public class DoctorsController : ApiController
    {
        // GET api/values
        public IEnumerable<DoctorViewModel> Get()
        {
            return new DoctorViewModel[] {
                new DoctorViewModel() {
                    DoctorId=Guid.Parse("842af74b-c69c-4fbf-a686-74dbbb27c55c"),
                    Name="Doctor Who"
                },
                new DoctorViewModel() {
                    DoctorId=Guid.Parse("821bfa5e-38ce-4217-889a-a2af52dbf65a"),
                    Name="Doctor McDreamy"
                }
            };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

}