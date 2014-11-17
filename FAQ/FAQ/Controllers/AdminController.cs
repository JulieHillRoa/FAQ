using FAQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace FAQ.Controllers
{
    public class AdminController : ApiController
    {
        //GET api/Admin

        public HttpResponseMessage getUnanswered()
        {
            DB db = new DB();
            List<Category> c = db.getCategoriesWithUnaswerdQuestions();
            c = c.OrderBy(s => s.categoryID).ToList();
            var Json = new JavaScriptSerializer();
            String JsonString = Json.Serialize(c);

            return new HttpResponseMessage()
            {
                Content = new StringContent(JsonString, Encoding.UTF8, "application/json"),
                StatusCode = HttpStatusCode.OK

            };

        }

        // GET api/Admin/5
        public HttpResponseMessage Get(int id)
        {
            DB db = new DB();
            Question question = db.getUnansweredQuestion(id);
            
            var Json = new JavaScriptSerializer();
            string JsonString = Json.Serialize(question);

            return new HttpResponseMessage()
            {
                Content = new StringContent(JsonString, Encoding.UTF8, "application/json"),
                StatusCode = HttpStatusCode.OK
            };
        }

        // PUT api/Admin/5
        public HttpResponseMessage Put(int id, [FromBody]Question q)
        {
            if (ModelState.IsValid)
            {
                DB db = new DB();
                bool OK = db.updateQuestion(q,id);
                if (OK)
                {
                    return new HttpResponseMessage()
                    {
                        StatusCode = HttpStatusCode.OK
                    };
                }
            }
            return new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.NotFound,
                Content = new StringContent("Kunne ikke endre spørsmålet i DB")
            };

        }

        // DELETE api/Admin/5
        public HttpResponseMessage Delete(int id)
        {
            if(ModelState.IsValid)
            {
             DB db = new DB();
                bool OK = db.removeQuestion(id);
                if (OK)
                {
                    return new HttpResponseMessage()
                    {
                        StatusCode = HttpStatusCode.OK
                    };
                }
            }
            return new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.NotFound,
                Content = new StringContent("Kunne ikke slette spørsmålet i DB")
            };
        }

    }
}
