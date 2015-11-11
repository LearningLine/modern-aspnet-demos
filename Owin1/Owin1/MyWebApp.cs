using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Runtime.Remoting.Contexts;
using Microsoft.Owin;
using Microsoft.Owin.Diagnostics;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;

namespace Owin1
{
    internal class MyWebApp
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.Use(async (context, next) =>
            {
                Console.WriteLine("Before next");
                await next();
                Console.WriteLine("After next");
            });
            appBuilder.Use(async (context, next) =>
            {
                using (var textWriter = new StreamWriter(@"c:\temp\test.txt"))
                {
                    await textWriter.WriteLineAsync(context.Request.Uri.ToString());
                }
                await next();
            });
            appBuilder.Use(async (context, next) =>
            {
                if (context.Request.Path.Value == "/forbidden") /// TEST ONLY
                    context.Response.StatusCode = 403;
                else
                    await next();
            });
            appBuilder.Use(async (context, next) =>
            {
                try
                {
                    await next();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    await context.Response.WriteAsync("There was a problem");
                }
            });
            appBuilder.Use(async (context, next) =>
            {
                if (context.Request.Path.Value.Contains("bad"))
                    throw new InvalidOperationException("Sorry");
                await next();
            });
            appBuilder.UseStaticFiles(new StaticFileOptions()
            {
                RequestPath = new PathString("/static"),
                FileSystem = new PhysicalFileSystem(@"c:\temp\static")
            });
            appBuilder.UseWelcomePage();
          
        }
    }
}