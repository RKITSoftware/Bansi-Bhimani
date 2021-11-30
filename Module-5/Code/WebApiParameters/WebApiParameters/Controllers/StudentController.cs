using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiParameters.Models;

namespace WebApiParameters.Controllers
{
    public class StudentController : ApiController
    {
        public IEnumerable<string> Get([FromUri] string id, [FromUri] string name)
        {
            return new string[]{
            $"The Id of the Student is {id}",
            $"The Name of the Student is {name}"
         };
        }

        public IEnumerable<string> Get([FromBody] Student student)
        {
            return new string[]{
            $"The Id of the Student is {student.Id}",
            $"The Name of the Student is {student.Name}"
         };
        }
    }
}
