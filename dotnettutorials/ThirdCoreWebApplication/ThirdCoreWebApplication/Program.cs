namespace ThirdCoreWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationOptions webApplicationOptions = new WebApplicationOptions
            {
                WebRootPath = "exclusivewebrootforcoolkidsonly",
                Args = args,
                EnvironmentName = "Development",
            };
            var builder = WebApplication.CreateBuilder(webApplicationOptions);
            var app = builder.Build();
            string resultString = "default very interesting string";

            ConfigurationManager configuration = builder.Configuration;
            resultString = configuration["AVeryImportantKey"];

            if (app.Environment.IsDevelopment())
            {
                DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions
                {
                    SourceCodeLineCount = 7
                };
                Console.WriteLine("im gay");
                app.UseDeveloperExceptionPage(developerExceptionPageOptions);
            }

            //app.UseRouting();

            //DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            //defaultFilesOptions.DefaultFileNames.Clear();
            //defaultFilesOptions.DefaultFileNames.Add("itsSquidward.html");
            //app.UseDefaultFiles(defaultFilesOptions);
            //app.UseStaticFiles();

            app.UseDirectoryBrowser();

            app.UseStaticFiles();

            //FileServerOptions fileServerOptions = new FileServerOptions();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("itsSquidward.html");
            //app.UseFileServer(fileServerOptions);

            //app.MapGet("/", () => $"EnvironmentName: {app.Environment.EnvironmentName}\n" +
            //  $"ApplicationName: {app.Environment.ApplicationName}\n" +
            //  $"WebRootPath: {app.Environment.WebRootPath}\n" +
            //  $"ContentRootPath: {app.Environment.ContentRootPath}");

            int num1 = 69;
            int num2 = 0;
            app.MapGet("/error", () => num1 / num2);
            app.Run();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync(resultString);
            //    });
            //    endpoints.MapGet("/potato", async context =>
            //    {
            //        await context.Response.WriteAsync("potatopotatopotatopotato");
            //    });
            //    endpoints.Map("/imdying", async context =>
            //    {
            //        Console.WriteLine("im literally dying rn");
            //        await context.Response.WriteAsync("as you can see from the console, i am dying rn");
            //    });
            //});

            if (Environment.GetEnvironmentVariable("POTATO_EXISTS") == "PotatoExists")
            {
                Console.WriteLine("oh my god you guys potato exists oh fuck oh shit");
                Console.WriteLine("fuckkkkkk");
            }

            //app.MapGet("/", () => resultString);
            //app.MapGet("/potato", () => "i hate myself lol");

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Here is the response from the first middleware!\n");
            //    await next();
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Here is the response from the second middleware");
            //});

            //app.Run();
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Omg its middlware 1 incoming\n");
            //    await next();
            //    await context.Response.WriteAsync("omfg its middleware 1 outgoing!\n");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("omgomgomgomg its middlware 2 incoming!\n");
            //    await next();
            //    await context.Response.WriteAsync("lmao its mmiddlware 2 outgoing!\n");
            //});
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Middleware 3 babyyy, handled, response generated!\n");
            //});
            //app.Run();
        }
    }
}