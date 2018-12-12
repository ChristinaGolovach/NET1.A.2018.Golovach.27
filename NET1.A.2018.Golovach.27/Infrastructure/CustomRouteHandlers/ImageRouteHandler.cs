using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using NET1.A._2018.Golovach._27.Infrastructure.CustomHttpHandlers;

namespace NET1.A._2018.Golovach._27.Infrastructure.CustomRouteHandlers
{
    public class ImageRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
            => new ImageHttpHandler();        

        //TODO ASK        
        // requestContext.HttpContext.Request.QueryString["name"] = (string)requestContext.RouteData.Values["id"];
    }
}