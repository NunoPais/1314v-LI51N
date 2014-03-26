using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleMvcApplication.Controllers
{

    
    public class FooX
    {
        public override string ToString()
        {
            return "x = " + x + " - foo = " + foo;
        }

        public FooX()
        {
            x = 22;
        }

        public FooX(String f)
        {
            foo = f;
        }
        public String foo { get; set; }
        public int x { get; set; }
    }

    public class MyActionResult : ActionResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
            HttpResponseBase rsp = context.RequestContext.HttpContext.Response;
            rsp.ContentType = "text/plain";
            rsp.Write("My action result execution");


        }

        public override string ToString()
        {
            return "MyActionResult";
        }
    }


    public class SampleController : Controller {


        public ActionResult SayHello(FooX fx)
        {
            //Response.ContentType = "text/plain";
            //return new ContentResult { Content = "Content result execution" };
            //return new JsonResult { Data = fx, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            return View((object)"ABC");
        }


        
        public String SayHelloPost(FooX fx)
        {
            Response.ContentType = "text/plain";


            return "Hello SLB o maior " + fx.foo + " " + fx.x;
        }


        
    }
}
