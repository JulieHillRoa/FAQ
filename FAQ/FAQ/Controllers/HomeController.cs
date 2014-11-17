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
    public class HomeController : ApiController
    {
       // GET api/Home/
        public HttpResponseMessage getAll()
        {
            DB db = new DB();
            List<Category> c = db.getCategories(null);
            c = c.OrderBy(s => s.categoryID).ToList();
            var Json = new JavaScriptSerializer();
            String JsonString = Json.Serialize(c);

            return new HttpResponseMessage()
            {
                Content = new StringContent(JsonString, Encoding.UTF8, "application/json"),
                StatusCode = HttpStatusCode.OK

            };

        }

        //POST api/Home
        public HttpResponseMessage Post(Question q)
        {
            if (ModelState.IsValid)
            {
                Question question = new Question();
                question.question = q.question;
                question.date = DateTime.Now;
                question.email = q.email;

                if(  q.categoryid == 0)
                    question.categoryid = 4;
                else  question.categoryid = q.categoryid;

                DB db = new DB();
                bool OK = db.addQuestion(question);
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
                Content = new StringContent("Kunne ikke sende inn spørsmålet")
            };
        }

        // GET api/Home/5
        public HttpResponseMessage Get(int id)
        {
            DB db = new DB();
            List<Category> c = db.getCategories(id);
            c = c.OrderBy(s => s.categoryID).ToList();
            var Json = new JavaScriptSerializer();
            String JsonString = Json.Serialize(c);

            return new HttpResponseMessage()
            {
                Content = new StringContent(JsonString, Encoding.UTF8, "application/json"),
                StatusCode = HttpStatusCode.OK

            };

        }

        
    }
}