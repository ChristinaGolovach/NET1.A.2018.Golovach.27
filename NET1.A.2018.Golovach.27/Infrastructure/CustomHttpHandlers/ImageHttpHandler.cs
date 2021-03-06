﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

// http://wfserverpaths.azurewebsites.net/ 

namespace NET1.A._2018.Golovach._27.Infrastructure.CustomHttpHandlers
{
    public class ImageHttpHandler : IHttpHandler
    {
        public bool IsReusable => false;


        public void ProcessRequest(HttpContext context)
        {
            //image/?name=1 - Task 1
            //string imageName = context.Request.QueryString["name"];
            
            // Task 2
            var imageName = context.Request.RequestContext.RouteData.Values["id"];
            string appPath = HttpRuntime.AppDomainAppPath;
            string path = $@"{appPath}\Images\{imageName}.jpg";

            if (!File.Exists(path))
            {
                context.Response.Write("Image does not exist");
            }
            else
            {
                context.Response.ContentType = "image/jpg";
                byte[] image = File.ReadAllBytes(path);
                context.Response.BinaryWrite(image);
            }                        
        }
    }
}