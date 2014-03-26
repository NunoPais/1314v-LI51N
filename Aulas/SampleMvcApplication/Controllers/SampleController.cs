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

    public class SampleController : Controller {

        public String SayHello(FooX fx)
        {
            Response.ContentType = "image/gif";
            return "Hello SLB " + fx.foo + " " + fx.x;
        }
        
    }
}
