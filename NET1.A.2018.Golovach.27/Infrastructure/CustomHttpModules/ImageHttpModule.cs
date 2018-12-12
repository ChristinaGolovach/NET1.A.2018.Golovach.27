using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NET1.A._2018.Golovach._27.Infrastructure.CustomHttpHandlers;

namespace NET1.A._2018.Golovach._27.Infrastructure.CustomHttpModules
{
    public class ImageHttpModule : IHttpModule
    {
        public void Dispose() { }

        public void Init(HttpApplication appContext)
        {
            appContext.PostResolveRequestCache += (sender, args) => 
            {
                string controllerSegment = (string)appContext.Context.Request.RequestContext.RouteData.Values["controller"];
                var idSegment = appContext.Context.Request.RequestContext.RouteData.Values["id"];

                if ((string.Equals(controllerSegment, "Image", StringComparison.OrdinalIgnoreCase) && idSegment !=null))
                {
                    appContext.Context.RemapHandler(new ImageHttpHandler());
                }
            };
        }

    }
}